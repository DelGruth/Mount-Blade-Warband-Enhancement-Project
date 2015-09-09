using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mount_and_Blade_Installer.Code.Mods
{
    class Downloader
    {

        public void downloadPolishedLandscapes()
        {
            Uri url = new Uri("http://www.mbrepository.com/download.php?id=2092&f=PL_Warband.rar");
            Windows.UI.Progress DP = new Windows.UI.Progress( url, "PL_Warband.rar");
            DP.Show();
}
        /*
        public void downloadRWT()
        {
            Uri url = new Uri("http://filedelivery.nexusmods.com/191/1648/Real_Water_v1-1.zip?ttl=1428046961&ri=8192&rs=8192&setec=ae291cb735ea2a9ef5c65c9b70b5adde");
            Windows.UI.Progress DP = new Windows.UI.Progress( url, "Real_Water_v1-1.zip");
            DP.Show();
        }
         * */


        public void downloadExpandedHorizons()
        {
            Uri url = new Uri("http://www.mbrepository.com/download.php?id=2387&f=ExpandedHorizonsV11.zip");
            Windows.UI.Progress DP = new Windows.UI.Progress(url, "ExpandedHorizonsV11.zip");
            DP.Show();
        }
        public void downloadSaarindTexture()
        {
            Uri url = new Uri("http://www.mbrepository.com/download.php?id=1985&f=Textures.zip");
            Windows.UI.Progress DP = new Windows.UI.Progress(url, "Textures.zip");
            DP.Show();
        }

        public void downloadBetterskyboxes()
        {
            Uri url = new Uri("http://www.mbrepository.com/download.php?id=2331&f=Better+Skyboxes.rar");
            Windows.UI.Progress DP = new Windows.UI.Progress(url, "Better_Skyboxes.rar");
            DP.Show();
        }
        public void downloadRealisticColors()
        {
            Uri url = new Uri("http://www.mbrepository.com/download.php?id=2018&f=Realistic+Colors+1.22.rar");
            Windows.UI.Progress DP = new Windows.UI.Progress(url, "Realistic_Colors_1.22.rar");
            DP.Show();
        }
        public void downloadTF()
        {
            Uri url = new Uri("http://www.mbrepository.com/download.php?id=2448&f=Texture+Fiddling+1.0.rar");
            Windows.UI.Progress DP = new Windows.UI.Progress(url, "Texture_Fiddling_1.0.rar");
            DP.Show();
        }
        public void ImprovedBuildings()
        {
            Uri url = new Uri("http://www.mbrepository.com/download.php?id=2323&f=Improved+Building+1.05a.rar");
            Windows.UI.Progress DP = new Windows.UI.Progress(url, "Improved_Building_1.05a.rar");
            DP.Show();
        }
        
        }

    }

