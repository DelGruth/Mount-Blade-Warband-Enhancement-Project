using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mount_and_Blade_Installer.Code.Mods.Polished_Landscape
{
    public class Manager
    {
        public void Install()
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            string newModuleini = File.ReadAllText(dir + @"/module.ini");
           newModuleini= newModuleini.Replace("load_resource = tree_meshes", "load_mod_resource = tree_meshes");
           newModuleini = newModuleini.Replace("load_resource = grass_meshes", "load_mod_resource = grass_meshes");
           newModuleini = newModuleini.Replace("load_resource = grass_meshes_b", "load_mod_resource = grass_meshes_b");
           newModuleini = newModuleini.Replace("load_resource = particle_meshes", "load_mod_resource = particle_meshes");
           newModuleini = newModuleini.Replace("load_resource = particles_2", "load_mod_resource = particles_2");
           newModuleini = newModuleini.Replace("load_resource = plant_meshes", "load_mod_resource = plant_meshes");
// newModuleini = newModuleini.Replace("load_resource = skyboxes", "load_mod_resource = skyboxes");
    //   LOOK HERE    newModuleini = newModuleini.Replace("load_resource = town_houses_e", "load_resource = town_houses_e"+Environment.NewLine+"load_mod_resource = flora_mod");
            File.WriteAllText(dir + @"/module.ini", newModuleini);
            Helper.Installs.Copy(System.Environment.CurrentDirectory + @"/PL_Warband/Polished_Landscapes/Resource", dir + "/Resource");
            Helper.Installs.Copy(System.Environment.CurrentDirectory + @"/PL_Warband/Polished_Landscapes/Textures", dir + "/Textures");
            dir = dir.Replace(@"\Modules\Native", "");
            File.Copy(System.Environment.CurrentDirectory + @"/PL_Warband/flora_kinds.txt", dir + "/Data/flora_kinds.txt",true);
            File.Copy(System.Environment.CurrentDirectory + @"/PL_Warband/ground_specs.txt", dir + "/Data/ground_specs.txt",true);
            Directory.Delete(Environment.CurrentDirectory + @"\PL_Warband", true);

        }
        public void Uninstall()
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            string newModuleini = File.ReadAllText(dir + @"/module.ini");
            newModuleini = newModuleini.Replace("load_mod_resource = tree_meshes", "load_resource = tree_meshes");
            newModuleini = newModuleini.Replace("load_mod_resource = grass_meshes", "load_resource = grass_meshes");
            newModuleini = newModuleini.Replace("load_mod_resource = grass_meshes_b", "load_resource = grass_meshes_b");
            newModuleini = newModuleini.Replace("load_mod_resource = particle_meshes", "load_resource = particle_meshes");
            newModuleini = newModuleini.Replace("load_mod_resource = particles_2", "load_resource = particles_2");
            newModuleini = newModuleini.Replace("load_mod_resource = plant_meshes", "load_resource = plant_meshes");
            newModuleini = newModuleini.Replace("load_mod_resource = skyboxes", "load_resource = skyboxes");
            newModuleini = newModuleini.Replace("load_mod_resource = flora_mod", "");
            File.WriteAllText(dir + @"/module.ini", newModuleini);

            DeleteFile(dir + @"/Resource/" + "env_materials.brf");
            DeleteFile(dir + @"/Resource/" + "grass_meshes.brf");
            DeleteFile(dir + @"/Resource/" + "grass_meshes_b.brf");
            DeleteFile(dir + @"/Resource/" + "map_tree_meshes.brf");
            DeleteFile(dir + @"/Resource/" + "particle_meshes.brf");
            DeleteFile(dir + @"/Resource/" + "particles_2.brf");
            DeleteFile(dir + @"/Resource/" + "plant_meshes.brf");
            DeleteFile(dir + @"/Resource/" + "terrain_borders.brf");
            DeleteFile(dir + @"/Resource/" + "tree_e_meshes.brf");
            DeleteFile(dir + @"/Resource/" + "tree_meshes.brf");
            DeleteFile(dir + @"/Resource/" + "xtree_meshes.brf");
            DeleteFile(dir + @"/Resource/" + "xtree_meshes_b.brf");
            DeleteFile(dir + @"/Resource/" + "xtree_meshes_c.brf");
            DeleteFile(dir + "/Textures/" + "bark.dds");
            DeleteFile(dir + "/Textures/" + "bark_b.dds");
            DeleteFile(dir + "/Textures/" + "bark_b_normalmap.dds");
            DeleteFile(dir + "/Textures/" + "bark_c.dds");
            DeleteFile(dir + "/Textures/" + "bark_c_normalmap.dds");
            DeleteFile(dir + "/Textures/" + "bark_normalmap.dds");
            DeleteFile(dir + "/Textures/" + "bushes.dds");
            DeleteFile(dir + "/Textures/" + "desert.dds");
            DeleteFile(dir + "/Textures/" + "desert_bump.dds");
            DeleteFile(dir + "/Textures/" + "desert1.dds");
            DeleteFile(dir + "/Textures/" + "dry_grass.dds");
            DeleteFile(dir + "/Textures/" + "dry_grass_bump.dds");
            DeleteFile(dir + "/Textures/" + "grape.dds");
            DeleteFile(dir + "/Textures/" + "grass.dds");
            DeleteFile(dir + "/Textures/" + "ground_earth.dds");
            DeleteFile(dir + "/Textures/" + "ground_earth_bump.dds");
            DeleteFile(dir + "/Textures/" + "ground_forest.dds");
            DeleteFile(dir + "/Textures/" + "ground_forest_bump.dds");
            DeleteFile(dir + "/Textures/" + "ground_path.dds");
            DeleteFile(dir + "/Textures/" + "ground_path_bump.dds");
            DeleteFile(dir + "/Textures/" + "ground1.dds");
            DeleteFile(dir + "/Textures/" + "ground1_bump.dds");
            DeleteFile(dir + "/Textures/" + "map_steppe.dds");
            DeleteFile(dir + "/Textures/" + "mountain.dds");
            DeleteFile(dir + "/Textures/" + "objects.dds");
            DeleteFile(dir + "/Textures/" + "particles.dds");
            DeleteFile(dir + "/Textures/" + "pebbles.dds");
            DeleteFile(dir + "/Textures/" + "plain.dds");
            DeleteFile(dir + "/Textures/" + "prt_text_rain_mud_1.dds");
            DeleteFile(dir + "/Textures/" + "rock_b.dds");
            DeleteFile(dir + "/Textures/" + "rock_b_normalmap.dds");
            DeleteFile(dir + "/Textures/" + "rock_b2.dds");
            DeleteFile(dir + "/Textures/" + "rock_c.dds");
            DeleteFile(dir + "/Textures/" + "rock_c_normalmap.dds");
            DeleteFile(dir + "/Textures/" + "skybox_clearday.dds");
            DeleteFile(dir + "/Textures/" + "skybox_cloud_2.dds");
            DeleteFile(dir + "/Textures/" + "skybox_cloud_1.dds");
            DeleteFile(dir + "/Textures/" + "skybox_night_1.dds");
            DeleteFile(dir + "/Textures/" + "skybox_sunset_1.dds");
            DeleteFile(dir + "/Textures/" + "snow.dds");
            DeleteFile(dir + "/Textures/" + "snow_bump.dds");
            DeleteFile(dir + "/Textures/" + "terrain_grassy.dds");
            DeleteFile(dir + "/Textures/" + "terrain_snowy.dds");
            DeleteFile(dir + "/Textures/" + "terrain_steppe.dds");
            DeleteFile(dir + "/Textures/" + "tree_a.dds");
            DeleteFile(dir + "/Textures/" + "tree_b.dds");
            DeleteFile(dir + "/Textures/" + "tree_c.dds");
            DeleteFile(dir + "/Textures/" + "tree_e.dds");
            DeleteFile(dir + "/Textures/" + "tree_e2.dds");
            DeleteFile(dir + "/Textures/" + "tree_f.dds");
            DeleteFile(dir + "/Textures/" + "trees.dds");
            DeleteFile(dir + "/Textures/" + "trees2.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_0.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_1.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_2.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_3.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_4.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_5.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_6.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_7.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_8.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_9.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_10.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_11.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_12.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_13.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_14.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_15.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_16.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_17.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_18.dds");
            DeleteFile(dir + "/Textures/" + "waterbump_19.dds");
            dir = dir.Replace(@"\Modules\Native", "");
            File.Copy(System.Environment.CurrentDirectory + @"\Assets\Native\Data\flora_kinds.txt", dir + "/Data/flora_kinds.txt",true);
            File.Copy(System.Environment.CurrentDirectory + @"\Assets\Native\Data\ground_specs.txt", dir + "/Data/ground_specs.txt",true);
           
        }

        private void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }

        /*
        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }
        */



    }
}
