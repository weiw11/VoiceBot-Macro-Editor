using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VoiceBot_Macro_Editor.Forms;
using VoiceBot_Macro_Editor.Handler;

namespace VoiceBot_Macro_Editor
{
    public partial class Main : Form
    {
        internal VoiceBotHandler handler = new VoiceBotHandler();

        public Main()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMacroFile();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            LoadMacroFile();
        }

        private void LoadMacroFile()
        {
            if (handler.LoadMacroFile())
            {
                txtboxFilePath.Text = handler.ofd.FileName;
                duplicateMacroToolStripMenuItem.Enabled = true;
                try
                {
                    rtbMacroInfo.Text = handler.GetVoiceBotProfileInformation();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid file");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void DuplicateMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Duplicate duplicate = new Duplicate();
            List<Macro> macros = handler.FindUniqueMacros();
            for (int i = 0; i < macros.Count; i++)
            {
                duplicate.comboBox.Items.Add(macros[i].Name);
            }
            duplicate.comboBox.SelectedIndex = 0;
            duplicate.handler = handler;
            duplicate.ShowDialog();
        }

        private void GetMacroFileInformation()
        {
            try
            {
                handler.DeserializeJSON(txtboxFilePath.Text);
                rtbMacroInfo.Text = handler.GetVoiceBotProfileInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid file");
                Console.WriteLine(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (handler.modified == true)
            {
                handler.SaveFile();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (handler.SaveFile())
            {
                this.Close();
            }
        }
    }
}