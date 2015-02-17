using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UITimer = System.Windows.Forms.Timer;

namespace SearchFiles
{
    public partial class Form1 : Form
    {
        
        private static bool run;
        private static bool run2;
        private UITimer timer = null;
        private DateTime beginSearchTime;
        public Form1()
        {
            InitializeComponent();
        }
        private void ListDirectory(string path, string mask, string findtext)
        {
            treeView1.Invoke((MethodInvoker)(() => treeView1.Nodes.Clear()));
            int filesFound = 0;
            int filesDone = 0;

            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            stack.Push(node);

            while (stack.Count > 0 && run)
            {
                var currentNode = stack.Pop();
                var directoryInfo = (DirectoryInfo)currentNode.Tag;
                bool check = false;
                try
                {
                    directoryInfo.GetDirectories();
                    check = true;
                }
                catch { }
                if (check) 
                {
                    foreach (var directory in directoryInfo.GetDirectories())
                    {
                        var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                        currentNode.Nodes.Add(childDirectoryNode);
                        stack.Push(childDirectoryNode);
                        if (!run) break;
                    }
                    foreach (var file in directoryInfo.GetFiles(mask))
                    {
                        processFileLabel.Invoke((MethodInvoker)delegate
                        { processFileLabel.Text = "Обрабатывается файл: " + file.FullName; });
                        System.IO.StreamReader rdfile = new System.IO.StreamReader(file.FullName);
                        string line;
                        while ((line = rdfile.ReadLine()) != null)
                        {
                            if (line.Contains(findtext)) //Found file with specified text
                            {
                                string[] split = file.FullName.Split('\\'); //Split path into dir names and file name
                                string splitname = "";
                                TreeNode savedresult = null; bool findlastresult = false;
                                foreach (string splitpart in split) //Code for realtime refreshing treeview and don't adding empty folders
                                {
                                    splitname += splitpart + "\\";
                                    TreeNode[] result;
                                    if (findlastresult)
                                    { result = savedresult.Nodes.Find(splitname, true); }
                                    else
                                    { result = treeView1.Nodes.Find(splitname, true); }
                                    if (result.Length == 0)
                                    {
                                        if (findlastresult)
                                        { treeView1.Invoke((MethodInvoker)(() => savedresult.Nodes.Add(splitname, splitpart))); }
                                        else
                                        { treeView1.Invoke((MethodInvoker)(() => treeView1.Nodes.Add(splitname, splitpart))); }
                                        result = treeView1.Nodes.Find(splitname, true);   
                                    }
                                    savedresult = result[0];
                                    findlastresult = true;
                                }
                                currentNode.Nodes.Add(new TreeNode(file.Name));
                                filesFound++;
                                
                                break;
                            }
                            if (!run) break;
                        }

                        filesDone++;
                        if (!run) break;
                        infoFileLabel.Invoke((MethodInvoker)delegate
                        { infoFileLabel.Text = "Обработано " + filesDone.ToString() + " файлов, найдено " + filesFound.ToString() + " файлов"; });
                    }
                }
            }

            setStopSearchState();
        }

        private void selectDirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                startDirTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (run2)
            {
                TimeSpan span = DateTime.Now.Subtract(beginSearchTime);
                infoTimeLabel.Text = "Прошло " + new DateTime(span.Ticks).ToString("HH:mm:ss tt");
            }
            else this.timer.Enabled = false;
        }
        private void setStopSearchState()
        {
            run = false;
            run2 = false;
            startButton.BeginInvoke(new Action(() => { startButton.Text = "Начать поиск"; }));
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (run)
            {
                setStopSearchState();
            }
            else
            {
                if (textBoxMask.Text == "")
                {
                    MessageBox.Show("Не задан шаблон имени файла.");
                }
                else
                {
                    string path = startDirTextBox.Text;
                    if (System.IO.Directory.Exists(path))
                    {
                        run = true; run2 = true;
                        startButton.Text = "Остановить поиск";
                        infoTimeLabel.Text = "Прошло 00:00:00";
                        infoFileLabel.Text = "Обработано 0 файлов, найдено 0 файлов";
                        beginSearchTime = DateTime.Now;
                        this.timer = new UITimer();
                        this.timer.Interval = 500;
                        this.timer.Tick += new EventHandler(timer_Tick);
                        this.timer.Enabled = true;
                        Thread searchThread = new Thread(delegate() { ListDirectory(path, textBoxMask.Text, textInFilesTextBox.Text); });
                        searchThread.Start();
                        searchThread.IsBackground = true;
                    }
                    else MessageBox.Show("Неправильная стартовая директория.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startDirTextBox.Text = Properties.Settings.Default.startDir;
            textBoxMask.Text = Properties.Settings.Default.mask;
            textInFilesTextBox.Text = Properties.Settings.Default.textInFiles;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["startDir"] = startDirTextBox.Text;
            Properties.Settings.Default["mask"] = textBoxMask.Text;
            Properties.Settings.Default["textInFiles"] = textInFilesTextBox.Text;
            Properties.Settings.Default.Save();
        }

    }
}
