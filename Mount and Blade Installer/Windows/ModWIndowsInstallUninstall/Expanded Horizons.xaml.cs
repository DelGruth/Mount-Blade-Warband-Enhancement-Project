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
    /// Interaction logic for Expanded_Horizons.xaml
    /// </summary>
    public partial class Expanded_Horizons : Window
    {
        public Expanded_Horizons()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Code.Mods.Downloader dl = new Code.Mods.Downloader();
            dl.downloadExpandedHorizons();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Code.Mods.Expanded_Horizons.Manager uninstall = new Code.Mods.Expanded_Horizons.Manager();
            uninstall.UnInstall();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mod_Windows.ModSelect_01 ms1 = new Mod_Windows.ModSelect_01();
            this.Close();
            ms1.Show();
        }
    }
}
