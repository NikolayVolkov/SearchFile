using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFiles
{
    public partial class ErrorReadFileForm : Form
    {
        public bool alwaysSkipNonReadingFiles { get; set; }
        public bool readingFile { get; set; }
        public ErrorReadFileForm(string file)
        {
            InitializeComponent();
            label2.Text = file;
        }

        private void ErrorReadFileForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            toolTip1.SetToolTip(label2, label2.Text);
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            this.readingFile = true;
            this.alwaysSkipNonReadingFiles = false;
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.ErrorReadFileForm_FormClosing);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            this.readingFile = false;
            this.alwaysSkipNonReadingFiles = false;
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.ErrorReadFileForm_FormClosing);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void alwaysAbortButton_Click(object sender, EventArgs e)
        {
            this.readingFile = false;
            this.alwaysSkipNonReadingFiles = true;
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.ErrorReadFileForm_FormClosing);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ErrorReadFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //Disable Alt+F4
        }


    }
}
