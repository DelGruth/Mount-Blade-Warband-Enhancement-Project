using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mount_and_Blade_Installer.Code.Mods.Sarnid_Alternate_Texture
{
    class Manager
    {
        public void Install()
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            Helper.Installs.Copy(Environment.CurrentDirectory + @"\Textures\Textures", dir + @"\Textures");
            Directory.Delete(Environment.CurrentDirectory + @"\Textures", true);

        }

        public void Uninstall()
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();

            File.Delete(dir + @"\Textures\" + "arabian_armor_a.dds");
            File.Delete(dir + @"\Textures\" + "archers_vest.dds");
            File.Delete(dir + @"\Textures\" + "hunting_horse.dds");
            File.Delete(dir + @"\Textures\" + "missiles.dds");
            File.Delete(dir + @"\Textures\" + "ragged_outfit_a.dds");
            File.Delete(dir + @"\Textures\" + "samurai.dds");
            File.Delete(dir + @"\Textures\" + "sarranian_mail_shirt.dds");
            File.Delete(dir + @"\Textures\" + "sarranid_cloth_robe.dds");
            File.Delete(dir + @"\Textures\" + "sarranid_cloth_robe_b.dds");
            File.Delete(dir + @"\Textures\" + "sarranid_helmets.dds");
            File.Delete(dir + @"\Textures\" + "sarranid_leather_armor.dds");
            File.Delete(dir + @"\Textures\" + "skirmisher_armor.dds");

        }

    }
}
