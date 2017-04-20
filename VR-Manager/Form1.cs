using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Manager
{
    public partial class FormVrManager : Form
    {
        private string boxSwitchActiveFileName = @"steamvr.vrsettings", boxSwitchInactiveFileName = @"steamvr.vrsettings.bat";
        public FormVrManager()
        {
            InitializeComponent();

            textBoxBoxSwitch.Text = Properties.Settings.Default.boxSwitchPath.Equals("") ? @"D:\Programme\Steam\config" : Properties.Settings.Default.boxSwitchPath;

            //TODO SOUND SWITCHER BAUEN!

            //TODO GITHUB einrichten!
        }

        private void buttonBoxPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogBoxSwitch.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.boxSwitchPath = folderBrowserDialogBoxSwitch.SelectedPath;
                Properties.Settings.Default.Save();
                textBoxBoxSwitch.Text = Properties.Settings.Default.boxSwitchPath;
            }
        }

        private void buttonSwitchBoxMode_Click(object sender, EventArgs e)
        {
            String folderPath = Properties.Settings.Default.boxSwitchPath;
            FileInfo activePath = new FileInfo(Path.Combine(folderPath, boxSwitchActiveFileName));
            if (activePath.Exists)
            {
                try
                {
                    FileInfo inactivePath = new FileInfo(Path.Combine(folderPath, boxSwitchInactiveFileName));
                    if (inactivePath.Exists)
                    {
                        FileInfo savePath = new FileInfo(Path.Combine(inactivePath.DirectoryName, inactivePath.Name + "TEMP"));
                        inactivePath.MoveTo(savePath.FullName);
                        activePath.MoveTo(Path.Combine(activePath.DirectoryName, activePath.Name + ".bat"));
                        inactivePath.MoveTo(Path.Combine(folderPath, boxSwitchActiveFileName));
                        MessageBox.Show("Room-Scaling-Einstellungen wurden getauscht!");
                    }
                    else
                    {
                        activePath.MoveTo(Path.Combine(activePath.DirectoryName, activePath.Name + ".bat"));
                        MessageBox.Show("Es wurde keine gespeicherte Raum-Einstellung gefunden!" +
                            Environment.NewLine + "Es muss ein neues Room-Scaling durchgeführt werden!" +
                            Environment.NewLine + "Die alte Einstellung ist unter dem folgenden Pfad zu finden: " + activePath.FullName);
                    }
                }
                catch (Exception er)
                {
                    Console.WriteLine("ERROR: " + er.Message);
                }
            }
            else
                MessageBox.Show("Es wurde keine Room-Scaling Einstellungen gefunden!");
        }
    }
}
