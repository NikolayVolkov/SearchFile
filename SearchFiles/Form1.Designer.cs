namespace SearchFiles
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.selectDirButton = new System.Windows.Forms.Button();
            this.startDirTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxMask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.infoFileLabel = new System.Windows.Forms.Label();
            this.processFileLabel = new System.Windows.Forms.Label();
            this.infoTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textInFilesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(12, 193);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(418, 226);
            this.treeView1.TabIndex = 0;
            // 
            // selectDirButton
            // 
            this.selectDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectDirButton.Location = new System.Drawing.Point(332, 5);
            this.selectDirButton.Name = "selectDirButton";
            this.selectDirButton.Size = new System.Drawing.Size(99, 23);
            this.selectDirButton.TabIndex = 1;
            this.selectDirButton.Text = "Выбрать папку";
            this.selectDirButton.UseVisualStyleBackColor = true;
            this.selectDirButton.Click += new System.EventHandler(this.selectDirButton_Click);
            // 
            // startDirTextBox
            // 
            this.startDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDirTextBox.Location = new System.Drawing.Point(12, 29);
            this.startDirTextBox.Name = "startDirTextBox";
            this.startDirTextBox.Size = new System.Drawing.Size(418, 20);
            this.startDirTextBox.TabIndex = 2;
            // 
            // textBoxMask
            // 
            this.textBoxMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMask.Location = new System.Drawing.Point(12, 68);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(418, 20);
            this.textBoxMask.TabIndex = 3;
            this.textBoxMask.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Шаблон имени файла:";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(12, 164);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(418, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Начать поиск";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // infoFileLabel
            // 
            this.infoFileLabel.AutoSize = true;
            this.infoFileLabel.Location = new System.Drawing.Point(101, 130);
            this.infoFileLabel.Name = "infoFileLabel";
            this.infoFileLabel.Size = new System.Drawing.Size(216, 13);
            this.infoFileLabel.TabIndex = 6;
            this.infoFileLabel.Text = "Обработано 0 файлов, найдено 0 файлов";
            // 
            // processFileLabel
            // 
            this.processFileLabel.AutoSize = true;
            this.processFileLabel.Location = new System.Drawing.Point(9, 148);
            this.processFileLabel.Name = "processFileLabel";
            this.processFileLabel.Size = new System.Drawing.Size(125, 13);
            this.processFileLabel.TabIndex = 7;
            this.processFileLabel.Text = "Обрабатывается файл:";
            // 
            // infoTimeLabel
            // 
            this.infoTimeLabel.AutoSize = true;
            this.infoTimeLabel.Location = new System.Drawing.Point(9, 130);
            this.infoTimeLabel.Name = "infoTimeLabel";
            this.infoTimeLabel.Size = new System.Drawing.Size(92, 13);
            this.infoTimeLabel.TabIndex = 8;
            this.infoTimeLabel.Text = "Прошло 00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Текст, содержащийся в файле:";
            // 
            // textInFilesTextBox
            // 
            this.textInFilesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInFilesTextBox.Location = new System.Drawing.Point(12, 107);
            this.textInFilesTextBox.Name = "textInFilesTextBox";
            this.textInFilesTextBox.Size = new System.Drawing.Size(418, 20);
            this.textInFilesTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Стартовая директория:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textInFilesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoTimeLabel);
            this.Controls.Add(this.processFileLabel);
            this.Controls.Add(this.infoFileLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMask);
            this.Controls.Add(this.startDirTextBox);
            this.Controls.Add(this.selectDirButton);
            this.Controls.Add(this.treeView1);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Text = "Поиск файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button selectDirButton;
        private System.Windows.Forms.TextBox startDirTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxMask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label infoFileLabel;
        private System.Windows.Forms.Label processFileLabel;
        private System.Windows.Forms.Label infoTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInFilesTextBox;
        private System.Windows.Forms.Label label3;
    }
}

