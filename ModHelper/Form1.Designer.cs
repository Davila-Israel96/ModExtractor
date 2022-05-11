namespace ModHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fromFolder = new System.Windows.Forms.TextBox();
            this.toFolder = new System.Windows.Forms.TextBox();
            this.fromFolderBtn = new System.Windows.Forms.Button();
            this.toFolderBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.startProcess = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromFolder
            // 
            this.fromFolder.Location = new System.Drawing.Point(110, 144);
            this.fromFolder.Name = "fromFolder";
            this.fromFolder.ReadOnly = true;
            this.fromFolder.Size = new System.Drawing.Size(196, 23);
            this.fromFolder.TabIndex = 0;
            // 
            // toFolder
            // 
            this.toFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toFolder.Location = new System.Drawing.Point(478, 144);
            this.toFolder.Name = "toFolder";
            this.toFolder.ReadOnly = true;
            this.toFolder.Size = new System.Drawing.Size(196, 23);
            this.toFolder.TabIndex = 1;
            // 
            // fromFolderBtn
            // 
            this.fromFolderBtn.Location = new System.Drawing.Point(164, 202);
            this.fromFolderBtn.Name = "fromFolderBtn";
            this.fromFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.fromFolderBtn.TabIndex = 2;
            this.fromFolderBtn.Text = "FROM";
            this.fromFolderBtn.UseVisualStyleBackColor = true;
            this.fromFolderBtn.Click += new System.EventHandler(this.fromFolderBtn_Click);
            // 
            // toFolderBtn
            // 
            this.toFolderBtn.Location = new System.Drawing.Point(544, 202);
            this.toFolderBtn.Name = "toFolderBtn";
            this.toFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.toFolderBtn.TabIndex = 3;
            this.toFolderBtn.Text = "TO";
            this.toFolderBtn.UseVisualStyleBackColor = true;
            this.toFolderBtn.Click += new System.EventHandler(this.toFolderBtn_Click);
            // 
            // startProcess
            // 
            this.startProcess.Location = new System.Drawing.Point(363, 253);
            this.startProcess.Name = "startProcess";
            this.startProcess.Size = new System.Drawing.Size(75, 23);
            this.startProcess.TabIndex = 4;
            this.startProcess.Text = "START";
            this.startProcess.UseVisualStyleBackColor = true;
            this.startProcess.Click += new System.EventHandler(this.startProcess_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(110, 338);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(581, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "ModExtractor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toFolder);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startProcess);
            this.Controls.Add(this.toFolderBtn);
            this.Controls.Add(this.fromFolderBtn);
            this.Controls.Add(this.fromFolder);
            this.Name = "Form1";
            this.Text = "ModExtractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fromFolder;
        private TextBox toFolder;
        private Button fromFolderBtn;
        private Button toFolderBtn;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button startProcess;
        private ProgressBar progressBar1;
        private Label label1;
    }
}