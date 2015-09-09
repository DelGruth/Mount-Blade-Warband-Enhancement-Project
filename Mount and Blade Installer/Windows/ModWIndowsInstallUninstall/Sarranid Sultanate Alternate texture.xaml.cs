using System.Windows;

namespace Mount_and_Blade_Installer.Windows.ModWIndowsInstallUninstall
{
    /// <summary>
    /// Interaction logic for Expanded_Horizons.xaml
    /// </summary>
    public partial class Sarranid_Sultanate_Alternate_texture : Window
    {
        public  Sarranid_Sultanate_Alternate_texture()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //install logic
            Code.Mods.Downloader dl = new Code.Mods.Downloader();
            dl.downloadSaarindTexture();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Code.Mods.Sarnid_Alternate_Texture.Manager uninstall = new Code.Mods.Sarnid_Alternate_Texture.Manager();
            uninstall.Uninstall();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mod_Windows.ModSelect_01 ms1 = new Mod_Windows.ModSelect_01();
            this.Close();
            ms1.Show();
        }


    }
}
