using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mount_and_Blade_Installer.Code.Mods.Realistic_Colors
{
    class Manager
    {
        public void install()
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            string newModuleini = File.ReadAllText(dir + @"\module.ini");
            Helper.Installs.Copy(Environment.CurrentDirectory + @"\Realistic_Colors_1.22\Realistic Colors 1.22\CommonRes", dir + @"\Resource");
            Helper.Installs.Copy(Environment.CurrentDirectory + @"\Realistic_Colors_1.22\Realistic Colors 1.22\Textures", dir + @"\Textures");
            newModuleini.Replace("load_resource = grass_meshes","load_mod_resource = grass_meshes");
            newModuleini.Replace("load_resource = grass_meshes_b","load_mod_resource = grass_meshes_b");
            File.WriteAllText(dir + @"\module.ini", newModuleini);
            Directory.Delete(Environment.CurrentDirectory + @"\Realistic_Colors_1.22", true);

        }

        public void uninstall()
        {
            string[] textures2Del = new string[] { "bark", "bark_b", "bark_c", "brick_wall" ,
            "building_details","building_details_2","building_details_3","building_details_4",
            "building_details_5","building_details_6","building_details_7","bush_a","bush_b","bush_c",
            "bushes","bushes_b","dry_grass","floor_1","grape","grass","ground_earth","ground_forest",
            "ground_path","ground_rocks_a","ground_stone1","ground_village","ground1","map_steppe",
            "mountain","objects","plain","plank_ship","planks","planks_2","planks_3","planks_4",
            "planks_5","planks_6","plant","raw_materials","rock","rock_a","rock_b","rock_c","roof_a",
            "roof_plates","roof_thatched","roof_tiles","stone","stone_buildings","stone_wall_2",
            "stone_wall_3","stone_wall_5","stone_wall_7","stone_wall_8","stone_wall_8b","stone_wall_9",
            "stone_wall_10","stucco_2","stucco_4","stucco_5","stucco_6","stucco_7","tent","terrain_grassy",
            "terrain_steppe","tree_a","tree_b","tree_c","tree_d","tree_e","tree_f","tree_new_a","tree_new_b",
            "tree_new_c","trees","trees2","trunks","trunks_height","vine","wall_snowy","wall3","wall4","wall5"
            };
            string[] brf2Del = new string[]{
                "grass_meshes_b","grass_meshes_a"
            };
            delete(brf2Del, textures2Del);
        }


        void delete(string[] Resources, string[] Textures)
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            foreach (string s in Textures)
            {
                File.Delete(dir + @"\Textures\"+s+".dds");
            }
            foreach (string s in Resources)
            {
                File.Delete(dir + @"\Resource\" + s+".brf");
            }        
        }


    }
}
