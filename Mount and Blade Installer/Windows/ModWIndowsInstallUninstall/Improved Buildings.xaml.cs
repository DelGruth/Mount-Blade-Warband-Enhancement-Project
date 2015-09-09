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
    /// Interaction logic for Improved_Buildings.xaml
    /// </summary>
    public partial class Improved_Buildings : Window
    {
        public Improved_Buildings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Code.Mods.Downloader dl = new Code.Mods.Downloader();
            dl.ImprovedBuildings();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mod_Windows.ModSelect_01 n = new Mod_Windows.ModSelect_01();
            this.Close();
            n.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Code.Mods.Improved_Buildings.Manager c = new Code.Mods.Improved_Buildings.Manager();
            c.uninstall();
        }
    }
}
