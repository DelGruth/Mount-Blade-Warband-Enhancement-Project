using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;


namespace Mount_and_Blade_Installer.Code.Script_Installer
{
  public  class InstallerScripts
    {

      public string directoryPath;

     
      
      
      public static void MainCopyFiles(string pointPath,string txtPath)
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
       public  void pathGetter(string dirPath)
       {
            directoryPath =dirPath;
           System.Diagnostics.Debug.WriteLine("pathgetter method has been called");
           System.Diagnostics.Debug.WriteLine("dirPath var @pathGetter "+ dirPath);
           System.Diagnostics.Debug.WriteLine("Directory var @pathgetter is " + directoryPath);

       }


      public void Install () {
         string dirPath = Mount_and_Blade_Installer.Code.Script_Installer.Directory_Determiner.DetermineDir();
         if (dirPath == null || dirPath == "" || dirPath == "false" )
         {
             System.Diagnostics.Debug.WriteLine("dirPath is not valid thus open window");
             Mount_and_Blade_Installer.Windows.Input_Windows.Window1 dirInput = new Windows.Input_Windows.Window1();
             dirInput.ShowDialog();
         }
         else
         {
             System.Diagnostics.Debug.WriteLine("dirPath is valid and dirpath var contains: " + dirPath);
             directoryPath = dirPath;
             System.Diagnostics.Debug.WriteLine(directoryPath);
         }
         System.Diagnostics.Debug.WriteLine("Calling the main sequence");
         MainCopyFiles(directoryPath, Directory.GetCurrentDirectory() +@"\Native" );
         System.Diagnostics.Debug.WriteLine("Done calling the main sequence");

         MessageBox.Show("Done installing the BNEM mod.");


      }




    public static void Copy(string sourceDir, string targetDir)
      {
          Directory.CreateDirectory(targetDir);

          foreach (var file in Directory.GetFiles(sourceDir))
              File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)),true);

          foreach (var directory in Directory.GetDirectories(sourceDir))
              Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
      }
    }
}
