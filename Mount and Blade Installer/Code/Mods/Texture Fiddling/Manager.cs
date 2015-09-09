using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mount_and_Blade_Installer.Code.Mods.Texture_Fiddling
{
    class Manager
    {
        public void Install()
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            Helper.Installs.Copy(Environment.CurrentDirectory + @"\Texture_Fiddling_1.0\Textures", dir + @"\Textures");
            Directory.Delete(Environment.CurrentDirectory + @"\Texture_Fiddling_1.0", true);

        }

        public void Uninstall()
        {
            string dir = Code.Script_Installer.Directory_Determiner.DetermineDir();
            string[] text2del = new string[] { "ankle_boots_a_new", "arabian_armor_a", "arabian_armor_b", "archers_vest", "arena_armorB",
            "arena_armorG","arena_armorR","arena_armorW","arena_armorY","arena_helmets","arena_tunicB","arena_tunicG","arena_tunicR","arena_tunicW","arena_tunicY",
            "banded_armor_a","blue_dress","blue_hose_a","bride_dress","brigandine_b","brown_dress_diff","byrnie_a","charger",
            "coarse_tunic_a","coat_of_plates","coat_of_plates_red","costumes3","cuir_bouilli_a","full_plate","fur_coat","gauntlets_new",
            "green_dress_diff","haubergeon_c","hauberk","head_wrapping","helmets","helmets_new_b","helmets_new_c","helmets_new_d","helmets_new_e","helmets_new_f",
            "helmets_new_g","helmets_new_h","heraldic_armor_a","heraldic_armor_b","heraldic_armor_c","heraldic_armor_d","hide_boots_a",
            "hunter_boots_a","hunting_horse","iron_greaves_a","khergit_armor","khergit_lady_dress_a","khergit_lady_dress_b","lamellar_armor_a","lamellar_armor_b",
            "lamellar_armor_c","lamellar_armor_d","lamellar_armor_e","lamellar_vest_a","lamellar_vest_b","leather_armor_a","leather_armor_b","leather_boots_a",
            "leather_greaves_a","leather_jacket","light_leather","light_mail_and_plate","mail_and_plate","mail_boots_a","mail_chausses_a","mail_long_surcoat",
            "mail_shirt_a","man_body8","map_icons_b","map_steppe","medieval_women_diff","nobleman_outfit_b","nomad_armor","nomad_boots_a","nomad_boots_a2",
            "nomad_vest_new","nordic_helmets_Diff","padded_cloth_a","padded_cloth_b","padded_cloth_c","peasant_man_a","plain","ragged_leather_jerkin",
            "ragged_outfit_a","red_gambeson_a","rich_tunic_a","saddle_horse","sarranian_mail_shirt",
            "sarranid_cloth_robe","sarranid_cloth_robe_b","sarranid_helmets","sarranid_lady_dress","sarranid_lady_dress_b","sarranid_leather_armor",
            "shields","shields_b","shirt_a","skirmisher_armor","splinted_greaves_a","sumpter_horse","surcoat_over_mail","tableau_shield_heater_1",
            "tableau_shield_heater_2","tableau_shield_kite_1","tableau_shield_kite_2","tableau_shield_kite_3","tableau_shield_kite_4",
            "tableau_shield_pavise_1","tableau_shield_pavise_2","tableau_shield_pavise_3","tableau_shield_round_1","tableau_shield_round_2",
            "tableau_shield_round_3","tableau_shield_round_4","tableau_shield_round_5","tableau_shield_small_round_1","tableau_shield_small_round_2",
            "tableau_shield_small_round_3","tattered_leather_armor_a","thick_coat_a","tribal_warrior_outfit_a","tunic_armor_a","vaegir_helmets",
            "warhorse_new","warhorse_sarranid","warhorse_steppe","weapons1","weapons2","weapons3","woolen_hose_a","lamellar_leather","peasant_dress_b"};
            Helper.Installs.delete(null, text2del);
        }


    }
}
