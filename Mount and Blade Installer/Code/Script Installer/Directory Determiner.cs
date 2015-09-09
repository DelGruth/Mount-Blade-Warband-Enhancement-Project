using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mount_and_Blade_Installer.Code.Script_Installer
{
    public class Directory_Determiner
    {

        public static string DetermineDir()
        {
            string dirPath = @"C:\Program Files (x86)\Steam\steamapps\common\MountBlade Warband\Modules\Native";
            if (Directory.Exists(dirPath))
                return dirPath;
            dirPath = @"C:\Program Files\Steam\steamapps\common\MountBlade Warband\Modules\Native";
            if (Directory.Exists(dirPath))
                return dirPath;
            dirPath = @"C:\Program Files (x86)\MountBlade Warband\Modules\Native";
            if (Directory.Exists(dirPath))
                return dirPath;
            dirPath = @"C:\Program Files\MountBlade Warband\Modules\Native";
            if (Directory.Exists(dirPath))
                return dirPath;
            dirPath = @"E:\Program Files (x86)\Steam\steamapps\common\MountBlade Warband\Modules\Native";
            if (Directory.Exists(dirPath))
                return dirPath;
            dirPath = @"E:\Program Files (x86)\MountBlade Warband\Modules\Native";
            if (Directory.Exists(dirPath))
                return dirPath;
            else
            {
                System.Diagnostics.Debug.WriteLine("dirPath is not valid thus open window");
                Mount_and_Blade_Installer.Windows.Input_Windows.Window1 dirInput = new Windows.Input_Windows.Window1();
                dirInput.ShowDialog();
            }

            return null;
        }
    }
}
