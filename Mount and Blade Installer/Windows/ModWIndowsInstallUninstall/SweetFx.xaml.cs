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

namespace Mount_and_Blade_Installer.Windows.ModWIndowsInstallUninstall.SweetFX
{
    /// <summary>
    /// Interaction logic for SweetFx.xaml
    /// </summary>
    public partial class SweetFx : Window
    {
        public SweetFx()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mod_Windows.ModSelect_01 MS1 = new Mod_Windows.ModSelect_01();
            this.Close();            MS1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Code.Script_Installer.SweetFXInstaller SweetInstaller = new Code.Script_Installer.SweetFXInstaller();
            SweetInstaller.Install();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Code.Script_Installer.SweerFXUninstaller SFXUI = new Code.Script_Installer.SweerFXUninstaller();
            SFXUI.Uninstaller();
        }
    }
}
