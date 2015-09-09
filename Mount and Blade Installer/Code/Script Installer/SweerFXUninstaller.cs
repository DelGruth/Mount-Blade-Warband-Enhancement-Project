using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace Mount_and_Blade_Installer.Code.Script_Installer
{
    class SweerFXUninstaller
    {

        string directoryPath;

        public void Uninstaller()
        {
            string dirPath = Mount_and_Blade_Installer.Code.Script_Installer.Directory_Determiner.DetermineDir();
            if (dirPath == null || dirPath == "" || dirPath == "false")
            {
                System.Diagnostics.Debug.WriteLine("dirPath is not valid thus open window");
                Mount_and_Blade_Installer.Windows.Input_Windows.Window1 dirInput = new Windows.Input_Windows.Window1();
                dirInput.ShowDialog();
            }
            else
            {
             //   int i =
             //  dirPath.Length - 15;
                System.Diagnostics.Debug.WriteLine("dirPath is valid and dirpath var contains: " + dirPath);
                directoryPath = dirPath;
             //  directoryPath.Remove(i);
                string toRemove = @"\Modules\Native";
               directoryPath = directoryPath.Replace(toRemove, "");
                System.Diagnostics.Debug.WriteLine(directoryPath + " @uninstallerscript");
            }
            File.Delete(directoryPath + "/d3d9.dll");
            File.Delete(directoryPath + "/d3d9.fx");
            File.Delete(directoryPath + "/dxgi.dll");
            File.Delete(directoryPath + "/dxgi.fx");
            File.Delete(directoryPath + "/injector.ini");
            File.Delete(directoryPath + "/shader.fx");
            File.Delete(directoryPath + "/SweetFX readme.txt");
            File.Delete(directoryPath + "/bnem_wbgi.txt");
            File.Delete(directoryPath + "/SweetFX_preset.txt");
            clearFolder(directoryPath + "/SweetFX");

            MessageBox.Show("Done removing SweetFX from warband.");
        }




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





            public static void Copy(string sourceDir, string targetDir)
      {
          Directory.CreateDirectory(targetDir);

          foreach (var file in Directory.GetFiles(sourceDir))
              File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)),true);

          foreach (var directory in Directory.GetDirectories(sourceDir))
              Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
      }
    
        public static void MainCopyFiles(string pointPath, string txtPath)
        {
            try
            {
                if (Directory.Exists(pointPath))
                {
                    Copy(txtPath, pointPath);
                }
                else
                {
                    MessageBox.Show("The Following directory does not exist:" + pointPath);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
    }
}
