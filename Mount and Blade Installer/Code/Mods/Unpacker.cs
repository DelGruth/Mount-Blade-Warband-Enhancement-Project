using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Mount_and_Blade_Installer.Code.Mods
{
    class Unpacker
    {
        public  void RarUnpack(string fileName)
        {
 


            var process =Process.Start(System.Environment.CurrentDirectory + "/Assets/7-Zip/7z.exe", "x -y "+ "Assets/7-Zip/" + fileName+ " -o*" );
            process.WaitForExit();
            File.Delete(Environment.CurrentDirectory + "/Assets/7-Zip/" + fileName);

            if (fileName == "PL_Warband.rar")
            {
                Polished_Landscape.Manager c = new Polished_Landscape.Manager();
                c.Install();
                MessageBox.Show("Polished Landscapes now installed");
            }
            if (fileName == "ExpandedHorizonsV11.zip")
            {
                Expanded_Horizons.Manager c = new Expanded_Horizons.Manager();
                c.Install();
                MessageBox.Show("Expanded Horizons now installed");
               
            }
            if (fileName == "Textures.zip")
            {
                Code.Mods.Sarnid_Alternate_Texture.Manager c = new Sarnid_Alternate_Texture.Manager();
                c.Install();
                MessageBox.Show("Alternative Sarranid texture mod installed");
            }
            if (fileName == "Better_Skyboxes.rar")
            {
                Code.Mods.Better_Skyboxes.Manager c = new Better_Skyboxes.Manager();
                c.install();
                MessageBox.Show("Better skyboxes now installed");
            }
            if (fileName == "Realistic_Colors_1.22.rar")
            {
                Code.Mods.Realistic_Colors.Manager c = new Realistic_Colors.Manager();
                c.install();
                MessageBox.Show("Realistic Colors Mod now installed");
            }
            if (fileName == "Texture_Fiddling_1.0.rar")
            {
                Code.Mods.Texture_Fiddling.Manager c = new Texture_Fiddling.Manager();
                c.Install();
                MessageBox.Show("Alternative Warband now installed");

            }
            if (fileName == "Improved_Building_1.05a.rar")
            {
                Code.Mods.Improved_Buildings.Manager c = new Improved_Buildings.Manager();
                c.install();
                MessageBox.Show("Improved Buildings now installed");

            }
        }
    }
}
