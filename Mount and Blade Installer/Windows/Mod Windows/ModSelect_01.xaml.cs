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

namespace Mount_and_Blade_Installer.Windows.Mod_Windows
{
    /// <summary>
    /// Interaction logic for ModSelect_01.xaml
    /// </summary>
    public partial class ModSelect_01 : Window
    {
        public ModSelect_01()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Windows.ModWIndowsInstallUninstall.SweetFX.SweetFx SFX1 = new Windows.ModWIndowsInstallUninstall.SweetFX.SweetFx();
            this.Close();
            SFX1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ModWIndowsInstallUninstall.PolishedLandscape PLs = new ModWIndowsInstallUninstall.PolishedLandscape();
            this.Close();
            PLs.Show();
       
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ModWIndowsInstallUninstall.Expanded_Horizons EH = new ModWIndowsInstallUninstall.Expanded_Horizons();
            this.Close();
            EH.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ModWIndowsInstallUninstall.Sarranid_Sultanate_Alternate_texture ssat = new ModWIndowsInstallUninstall.Sarranid_Sultanate_Alternate_texture();
            this.Close();
            ssat.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ModWIndowsInstallUninstall.Better_Skyboxes bs = new ModWIndowsInstallUninstall.Better_Skyboxes();
            this.Close();
            bs.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ModWIndowsInstallUninstall.Realistic_Colors rc = new ModWIndowsInstallUninstall.Realistic_Colors();
            this.Close();
            rc.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ModWIndowsInstallUninstall.Alternate_Warband aw = new ModWIndowsInstallUninstall.Alternate_Warband();
            this.Close();
            aw.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ModWIndowsInstallUninstall.Improved_Buildings ib = new ModWIndowsInstallUninstall.Improved_Buildings();
            this.Close();
            ib.Show();
     }
        /*         Code.Helper.nameGenerator ng = new Code.Helper.nameGenerator();
            ng.Determine(Environment.CurrentDirectory + @"/Improved_Building_1.05a/Improved Building 1.05a/Textures", @"/Improved_Building_1.05a/Improved Building 1.05a/Textures\");
      
         */
        //    Code.Helper.nameGenerator ng = new Code.Helper.nameGenerator();
        //    ng.Determine(Environment.CurrentDirectory + @"\");
    }
}
