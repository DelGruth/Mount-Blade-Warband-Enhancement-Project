using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Mount_and_Blade_Installer.Windows.Input_Windows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tempDir = textInput.Text;
            if (Directory.Exists(tempDir))
            {
                Mount_and_Blade_Installer.Code.Script_Installer.InstallerScripts IS1 = new Code.Script_Installer.InstallerScripts();
                IS1.pathGetter(tempDir);
                MessageBox.Show("The Directory where the mod is being installed too is" + tempDir);
                Mount_and_Blade_Installer.Code.Script_Installer.Backup IS2 = new Code.Script_Installer.Backup();
                IS2.pathGetter(tempDir);
                Mount_and_Blade_Installer.Code.Script_Installer.Restore_Native IS3 = new Code.Script_Installer.Restore_Native();
                IS3.pathGetter(tempDir);
                this.Close();

            }
            else
            {
                textInput.Text = "The directory is incorrect please try again....";
            }
        }
    }
}
