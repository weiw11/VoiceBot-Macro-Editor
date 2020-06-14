using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VoiceBot_Macro_Editor.Handler
{
    public class VoiceBotHandler
    {
        public VoiceBot voicebot { get; set; }
        public bool modified = false;
        public OpenFileDialog ofd { get; set; }
        public SaveFileDialog sfd { get; set; }

        public VoiceBot DeserializeJSON(string path)
        {
            voicebot = JsonConvert.DeserializeObject<VoiceBot>(File.ReadAllText(path, Encoding.Unicode));
            return voicebot;
        }

        public string SerializeJSON()
        {
            return JsonConvert.SerializeObject(voicebot);
        }

        public Macro FindMacroByNameInList(string name)
        {
            return voicebot.Macros.FirstOrDefault(c => c.Name == name);
        }

        public int CountMacros()
        {
            return voicebot.Macros.Count;
        }

        public int CountUniqueMacros()
        {
            return FindUniqueMacros().Count();
        }

        public string GetVoiceBotProfileInformation()
        {
            return
                "Name: " + voicebot.Name + "\n" +
                "Prefix: " + voicebot.Prefix + "\n" +
                "Global: " + voicebot.Global + "\n" +
                "Language: " + voicebot.Culturecode + "\n" +
                "Macro Count: " + CountMacros() + "\n" +
                "Unique Macro Count: " + CountUniqueMacros() + "\n" +
                "WallpaperFusion Tag: " + voicebot.Wpftagname + "\n" +
                "WallpaperFusion Slug: " + voicebot.Wpftagslug + "\n" +
                "Associated Processes: [" + voicebot.Filename + "]\n" +
                "Description: " +
                "\n==================================================\n" +
                voicebot.Desc + "\n==================================================\n";
        }

        public List<Macro> FindUniqueMacros()
        {
            List<Macro> newMacro = new List<Macro>();
            string previous = voicebot.Macros[0].Actions[0].Value; ;
            newMacro.Add(voicebot.Macros[0]);
            for (int i = 1; i < voicebot.Macros.Count; i++)
            {
                if (voicebot.Macros[i].Actions[0].Value != previous && !newMacro.Contains(voicebot.Macros[i]))
                {
                    newMacro.Add(voicebot.Macros[i]);
                    previous = voicebot.Macros[i].Actions[0].Value;
                }
                else
                {
                    continue;
                }
            }
            return newMacro;
        }

        public bool ReplaceMacroText(string name, string replaceText, string[] lines)
        {
            try
            {
                Macro macro = FindMacroByNameInList(name);

                foreach (string s in lines)
                {
                    List<Action> actions = new List<Action>();

                    for (int i = 0; i < macro.Actions.Count; i++)
                    {
                        Action action = new Action(macro.Actions[i].ActionAction, macro.Actions[i].Value, macro.Actions[i].References);
                        action.Replace(replaceText, s);
                        actions.Add(action);
                    }
                    macro = new Macro(macro.Name, macro.Description, macro.Hotkey, macro.Disabled, macro.BuiltIn, macro.Command, macro.Group, actions);
                    macro.Replace(replaceText, s);
                    voicebot.Macros.Add(macro);
                    replaceText = s;
                }
                modified = true;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SaveFile()
        {
            try
            {
                using (sfd = new SaveFileDialog()
                {
                    InitialDirectory = @"C:\",
                    Title = "Save Voicebot Macro",
                    DefaultExt = "voicebot",
                    Filter = "voicebot files (*.voicebot)|*.voicebot",
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, SerializeJSON(), Encoding.Unicode);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool LoadMacroFile()
        {
            try
            {
                using (ofd = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Browse Voicebot Macro",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "voicebot",
                    Filter = "voicebot files (*.voicebot)|*.voicebot",
                    RestoreDirectory = true,
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        DeserializeJSON(ofd.FileName);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}