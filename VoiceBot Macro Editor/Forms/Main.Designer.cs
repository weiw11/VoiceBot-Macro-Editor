namespace VoiceBot_Macro_Editor
{
    partial class Main
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
            this.txtboxFilePath = new System.Windows.Forms.TextBox();
            this.rtbMacroInfo = new System.Windows.Forms.RichTextBox();
            this.msVB = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lbVBInfo = new System.Windows.Forms.Label();
            this.msVB.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxFilePath
            // 
            this.txtboxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxFilePath.Location = new System.Drawing.Point(93, 29);
            this.txtboxFilePath.Name = "txtboxFilePath";
            this.txtboxFilePath.ReadOnly = true;
            this.txtboxFilePath.Size = new System.Drawing.Size(695, 20);
            this.txtboxFilePath.TabIndex = 1;
            // 
            // rtbMacroInfo
            // 
            this.rtbMacroInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMacroInfo.Location = new System.Drawing.Point(12, 99);
            this.rtbMacroInfo.Name = "rtbMacroInfo";
            this.rtbMacroInfo.ReadOnly = true;
            this.rtbMacroInfo.Size = new System.Drawing.Size(776, 339);
            this.rtbMacroInfo.TabIndex = 2;
            this.rtbMacroInfo.Text = "";
            this.rtbMacroInfo.WordWrap = false;
            // 
            // msVB
            // 
            this.msVB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msVB.Location = new System.Drawing.Point(0, 0);
            this.msVB.Name = "msVB";
            this.msVB.Size = new System.Drawing.Size(800, 24);
            this.msVB.TabIndex = 3;
            this.msVB.Text = "VoiceBot Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateMacroToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.toolsToolStripMenuItem.Text = "Macro";
            // 
            // duplicateMacroToolStripMenuItem
            // 
            this.duplicateMacroToolStripMenuItem.Enabled = false;
            this.duplicateMacroToolStripMenuItem.Name = "duplicateMacroToolStripMenuItem";
            this.duplicateMacroToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.duplicateMacroToolStripMenuItem.Text = "Bulk Duplicate";
            this.duplicateMacroToolStripMenuItem.Click += new System.EventHandler(this.DuplicateMacroToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 27);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 4;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lbVBInfo
            // 
            this.lbVBInfo.AutoSize = true;
            this.lbVBInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVBInfo.Location = new System.Drawing.Point(8, 76);
            this.lbVBInfo.Name = "lbVBInfo";
            this.lbVBInfo.Size = new System.Drawing.Size(236, 20);
            this.lbVBInfo.TabIndex = 5;
            this.lbVBInfo.Text = "Voicebot Macro Information:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbVBInfo);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.rtbMacroInfo);
            this.Controls.Add(this.txtboxFilePath);
            this.Controls.Add(this.msVB);
            this.MainMenuStrip = this.msVB;
            this.Name = "Main";
            this.Text = "Voicebot Macro Editor";
            this.msVB.ResumeLayout(false);
            this.msVB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxFilePath;
        private System.Windows.Forms.RichTextBox rtbMacroInfo;
        private System.Windows.Forms.MenuStrip msVB;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateMacroToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lbVBInfo;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

