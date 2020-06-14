namespace VoiceBot_Macro_Editor.Forms
{
    partial class Duplicate
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
            this.macroList = new System.Windows.Forms.ComboBox();
            this.lbSelectMacro = new System.Windows.Forms.Label();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.lbReplaceText = new System.Windows.Forms.Label();
            this.lbInput = new System.Windows.Forms.Label();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.cbReplaceList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // macroList
            // 
            this.macroList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.macroList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.macroList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.macroList.FormattingEnabled = true;
            this.macroList.Location = new System.Drawing.Point(286, 46);
            this.macroList.Name = "macroList";
            this.macroList.Size = new System.Drawing.Size(121, 21);
            this.macroList.TabIndex = 0;
            this.macroList.SelectedIndexChanged += new System.EventHandler(this.macroList_SelectedIndexChanged);
            // 
            // lbSelectMacro
            // 
            this.lbSelectMacro.AutoSize = true;
            this.lbSelectMacro.Location = new System.Drawing.Point(283, 30);
            this.lbSelectMacro.Name = "lbSelectMacro";
            this.lbSelectMacro.Size = new System.Drawing.Size(76, 13);
            this.lbSelectMacro.TabIndex = 1;
            this.lbSelectMacro.Text = "Select Macro: ";
            // 
            // rtbInput
            // 
            this.rtbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbInput.DetectUrls = false;
            this.rtbInput.Location = new System.Drawing.Point(12, 46);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbInput.Size = new System.Drawing.Size(265, 232);
            this.rtbInput.TabIndex = 2;
            this.rtbInput.Text = "";
            // 
            // lbReplaceText
            // 
            this.lbReplaceText.AutoSize = true;
            this.lbReplaceText.Location = new System.Drawing.Point(283, 95);
            this.lbReplaceText.Name = "lbReplaceText";
            this.lbReplaceText.Size = new System.Drawing.Size(89, 13);
            this.lbReplaceText.TabIndex = 4;
            this.lbReplaceText.Text = "Text to Replace: ";
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(12, 30);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(114, 13);
            this.lbInput.TabIndex = 5;
            this.lbInput.Text = "Text to Replace With: ";
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(332, 159);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(75, 23);
            this.btnDuplicate.TabIndex = 6;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // cbReplaceList
            // 
            this.cbReplaceList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbReplaceList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReplaceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReplaceList.FormattingEnabled = true;
            this.cbReplaceList.Location = new System.Drawing.Point(286, 111);
            this.cbReplaceList.Name = "cbReplaceList";
            this.cbReplaceList.Size = new System.Drawing.Size(121, 21);
            this.cbReplaceList.TabIndex = 8;
            // 
            // Duplicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 300);
            this.Controls.Add(this.cbReplaceList);
            this.Controls.Add(this.btnDuplicate);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.lbReplaceText);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.lbSelectMacro);
            this.Controls.Add(this.macroList);
            this.Name = "Duplicate";
            this.Text = "Duplicate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox macroList;
        private System.Windows.Forms.Label lbSelectMacro;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label lbReplaceText;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.ComboBox cbReplaceList;
    }
}