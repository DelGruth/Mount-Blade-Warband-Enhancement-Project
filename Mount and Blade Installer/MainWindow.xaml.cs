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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mount_and_Blade_Installer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mount_and_Blade_Installer.Code.Script_Installer.InstallerScripts t1 = new Code.Script_Installer.InstallerScripts();
            t1.Install();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Code.Script_Installer.Backup bu = new Code.Script_Installer.Backup();
            bu.InstallBackup();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Code.Script_Installer.Restore_Native RESN = new Code.Script_Installer.Restore_Native();
            RESN.RestoreScript();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Windows.Mod_Windows.ModSelect_01 MS1 = new Windows.Mod_Windows.ModSelect_01();
            this.Close();
            MS1.Show();
        }
    }
}
