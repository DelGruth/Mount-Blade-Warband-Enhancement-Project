using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mount_and_Blade_Installer.Code.Helper
{
    class Installs
    {
        public static void delete(string[] Resources, string[] Textures)
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            foreach (string s in Textures)
            {
                File.Delete(dir + @"\Textures\" + s + ".dds");
            }
            if (Resources == null)
                return;
            foreach (string s in Resources)
            {
                File.Delete(dir + @"\Resource\" + s + ".brf");
            }
        }
        public static void delete(string[] Resources, string[] Textures,bool tags)
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            foreach (string s in Textures)
            {
                File.Delete(dir + @"\Textures\" + s );
            }
            if (Resources == null)
                return;
            foreach (string s in Resources)
            {
                File.Delete(dir + @"\Resource\" + s);
            }
        }
        public static void Copy(string sourceDir, string targetDir)
        {        
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        
        }

    }
}
