using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace Mount_and_Blade_Installer.Code.Mods.Expanded_Horizons
{
    class Manager
    {
        public void Install()
        {
            try
            {
                string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
                string newModuleini = File.ReadAllText(dir + @"/module.ini");
                Helper.Installs.Copy(System.Environment.CurrentDirectory + @"\ExpandedHorizonsV11\CommonRes", dir + @"\Resource");
                Helper.Installs.Copy(System.Environment.CurrentDirectory + @"\ExpandedHorizonsV11\Textures", dir + @"\Textures");
                newModuleini = newModuleini.Replace("load_resource = terrain_borders_b", "");
                newModuleini = newModuleini.Replace("load_resource = terrain_borders", "load_mod_resource = op_terrain_borders_textures" + Environment.NewLine + "load_mod_resource = op_terrain_borders_materials" + Environment.NewLine + "load_mod_resource = op_terrain_borders" + Environment.NewLine + "load_mod_resource = op_terrain_borders_b");
            

                File.WriteAllText(dir + @"/module.ini", newModuleini);
                Directory.Delete(Environment.CurrentDirectory + @"\ExpandedHorizonsV11", true);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        public void UnInstall()
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            DeleteFile(dir + @"\Resource\" + "op_terrain_borders_textures.brf");
            DeleteFile(dir + @"\Resource\" + "op_terrain_borders_materials.brf");
            DeleteFile(dir + @"\Resource\" + "op_terrain_borders_b.brf");
            DeleteFile(dir + @"\Resource\" + "op_terrain_borders.brf");
            DeleteFile(dir + @"\Textures\" + "op_steppe_far.dds");
            DeleteFile(dir + @"\Textures\" + "op_snow_far.dds");
            DeleteFile(dir + @"\Textures\" + "op_plains_far.dds");
            DeleteFile(dir + @"\Textures\" + "op_desert_far.dds");
            string newModuleini = File.ReadAllText(dir + @"/module.ini");
            newModuleini = newModuleini.Replace("load_mod_resource = op_terrain_borders_textures" + Environment.NewLine + "load_mod_resource = op_terrain_borders_materials" + Environment.NewLine + "load_mod_resource = op_terrain_borders" + Environment.NewLine + "load_mod_resource = op_terrain_borders_b", "load_resource = terrain_borders"+Environment.NewLine + "load_resource = terrain_borders_b");
            File.WriteAllText(dir + @"/module.ini", newModuleini);

        }
        private void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }


    }
}
