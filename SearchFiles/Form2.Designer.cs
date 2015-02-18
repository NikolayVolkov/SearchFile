namespace SearchFiles
{
    partial class ErrorReadFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.alwaysAbortButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Не удалось прочитать файл";
            // 
            // retryButton
            // 
            this.retryButton.Location = new System.Drawing.Point(12, 75);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(120, 23);
            this.retryButton.TabIndex = 1;
            this.retryButton.Text = "Повторить";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(138, 75);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(120, 23);
            this.abortButton.TabIndex = 2;
            this.abortButton.Text = "Пропустить";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // alwaysAbortButton
            // 
            this.alwaysAbortButton.Location = new System.Drawing.Point(264, 75);
            this.alwaysAbortButton.Name = "alwaysAbortButton";
            this.alwaysAbortButton.Size = new System.Drawing.Size(120, 23);
            this.alwaysAbortButton.TabIndex = 3;
            this.alwaysAbortButton.Text = "Всегда пропускать";
            this.alwaysAbortButton.UseVisualStyleBackColor = true;
            this.alwaysAbortButton.Click += new System.EventHandler(this.alwaysAbortButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторить?";
            // 
            // ErrorReadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 111);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alwaysAbortButton);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.label1);
            this.Name = "ErrorReadFileForm";
            this.Text = "Ошибка чтения файла";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ErrorReadFileForm_FormClosing);
            this.Load += new System.EventHandler(this.ErrorReadFileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button alwaysAbortButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}