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

namespace Mount_and_Blade_Installer.Windows.ModWIndowsInstallUninstall
{
    /// <summary>
    /// Interaction logic for Alternate_Warband.xaml
    /// </summary>
    public partial class Alternate_Warband : Window
    {
        public Alternate_Warband()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Code.Mods.Downloader dl = new Code.Mods.Downloader();
            dl.downloadTF();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Code.Mods.Texture_Fiddling.Manager c = new Code.Mods.Texture_Fiddling.Manager();
            c.Uninstall();
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mod_Windows.ModSelect_01 n = new Mod_Windows.ModSelect_01();
            this.Close();
            n.Show();
        }
    }
}
