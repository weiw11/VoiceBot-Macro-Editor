using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VoiceBot_Macro_Editor.Handler;

namespace VoiceBot_Macro_Editor.Forms
{
    public partial class Duplicate : Form
    {
        public ComboBox comboBox;
        public VoiceBotHandler handler;

        public Duplicate()
        {
            InitializeComponent();
            comboBox = macroList;
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            DuplicateMacro(cbReplaceList.SelectedItem.ToString());
        }

        private void DuplicateMacro(string replaceText)
        {
            if (handler.ReplaceMacroText(macroList.SelectedItem.ToString(), replaceText, rtbInput.Lines))
            {
                handler.SaveFile();
                this.Close();
            }
        }

        private void macroList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbReplaceList.Items.Clear();
            cbReplaceList.Items.AddRange(macroList.SelectedItem.ToString().Split());
            cbReplaceList.SelectedIndex = 0;
            cbReplaceList.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}