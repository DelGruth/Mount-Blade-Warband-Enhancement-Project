using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mount_and_Blade_Installer.Code.Mods.Improved_Buildings
{
    class Manager
    {
        public void install()
        {
           // Improved_Building_1.05a.rar
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            Helper.Installs.Copy(Environment.CurrentDirectory + @"/Improved_Building_1.05a/Improved Building 1.05a/Textures", dir + @"/Textures");
            Directory.Delete(Environment.CurrentDirectory + @"/Improved_Building_1.05a",true);
        }

        public void uninstall()
        {
            string[] text2Del = new string[] {
                "brick_wall.dds" ,
"building_1b_alpha.dds" ,
"building_alpha.dds" ,
"building_details.dds" ,
"building_details_2.dds" ,
"building_details_3.dds" ,
"building_details_4.dds" ,
"building_details_5.dds" ,
"building_details_5_n.dds" ,
"building_details_6.dds" ,
"building_details_6_n.dds" ,
"building_details_7.dds" ,
"building_details_7_n.dds" ,
"carpet_a.dds" ,
"carpet_b.dds" ,
"carpet_c.dds" ,
"floor_1.dds" ,
"floor_1_height.dds" ,
"floor_1_s.dds" ,
"ground_path.dds" ,
"ground_path_bump.dds" ,
"ground_stone1.dds" ,
"ground_village.dds" ,
"ground_village_bump.dds" ,
"objects.dds" ,
"planks.dds" ,
"planks_2.dds" ,
"planks_2_height.dds" ,
"planks_3.dds" ,
"planks_4.dds" ,
"planks_4_height.dds" ,
"planks_5.dds" ,
"planks_5_n.dds" ,
"planks_6.dds" ,
"planks_6_n.dds" ,
"planks_height.dds" ,
"planks_snowy.dds" ,
"plank_ship.dds" ,
"plank_ship_n.dds" ,
"roof_a.dds" ,
"roof_a_n.dds" ,
"roof_plates.dds" ,
"roof_plates_height.dds" ,
"roof_plates_new.dds" ,
"roof_thatched.dds" ,
"roof_thatched_n.dds" ,
"roof_tiles.dds" ,
"rushes.dds" ,
"stone.dds" ,
"stone_buildings.dds" ,
"stone_wall_10.dds" ,
"stone_wall_10_height.dds" ,
"stone_wall_2.dds" ,
"stone_wall_2_height.dds" ,
"stone_wall_3.dds" ,
"stone_wall_3_height.dds" ,
"stone_wall_5.dds" ,
"stone_wall_5_height.dds" ,
"stone_wall_7.dds" ,
"stone_wall_7_height.dds" ,
"stone_wall_8.dds" ,
"stone_wall_8b.dds" ,
"stone_wall_8_height.dds" ,
"stone_wall_9.dds" ,
"stone_wall_9_height.dds" ,
"stucco_2.dds" ,
"stucco_2_height.dds" ,
"stucco_4.dds" ,
"stucco_4_height.dds" ,
"stucco_5.dds" ,
"stucco_5_n.dds" ,
"stucco_6.dds" ,
"stucco_6_n.dds" ,
"stucco_7.dds" ,
"stucco_7_n.dds" ,
"stucco_snowy.dds" ,
"trunks.dds" ,
"trunks_height.dds" ,
"trunks_snowy.dds" ,
"trunks_snowy_normalmap.dds" ,
"wall3.dds" ,
"wall3_height.dds" ,
"wall3_snowy.dds" ,
"wall4.dds" ,
"wall4_height.dds" ,
"wall5.dds" ,
"wall5_height.dds" ,
"wall_snowy.dds" ,

            };
            Code.Helper.Installs.delete(null, text2Del, true);
        }


    }
}
