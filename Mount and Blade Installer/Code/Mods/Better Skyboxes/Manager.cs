using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mount_and_Blade_Installer.Code.Mods.Better_Skyboxes
{
    class Manager
    {
        public void install()
        {
            
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            string newModuleini = File.ReadAllText(dir + @"/module.ini");

           Helper.Installs.Copy(Environment.CurrentDirectory + @"\Better_Skyboxes\Textures", dir + @"\Textures");
           Helper.Installs.Copy(Environment.CurrentDirectory + @"\Better_Skyboxes\Resource", dir + @"\Resource");
            newModuleini =newModuleini.Replace("load_resource = skyboxes", "load_mod_resource = skyboxes");
            File.WriteAllText(dir + @"/module.ini", newModuleini);
            Directory.Delete(Environment.CurrentDirectory + @"\Better_Skyboxes", true);
        }

        public void uninstall()
        {
            
            string dir =  Code.Script_Installer.Directory_Determiner.DetermineDir();
            string newModuleini = File.ReadAllText(dir + @"/module.ini");

            File.Delete(dir + @"\Textures\" + "skybox_cloud_1_sm.dds");
            File.Delete(dir + @"\Textures\" + "skybox_clearday_sm.dds");
            File.Delete(dir + @"\Textures\" + "skybox_cloud_2_sm.dds");
            File.Delete(dir + @"\Textures\" + "skybox_night_1_sm.dds");
            File.Delete(dir + @"\Textures\" + "skybox_night_2_sm.dds");
            File.Delete(dir + @"\Textures\" + "skybox_sunset_1_sm.dds");
            File.Delete(dir + @"\Resource\" + "skyboxes.brf");
            newModuleini = newModuleini.Replace("load_mod_resource = skyboxes ", "load_resource = skyboxes ");

            File.WriteAllText(dir + @"/module.ini", newModuleini);
            

        }


    }
}
