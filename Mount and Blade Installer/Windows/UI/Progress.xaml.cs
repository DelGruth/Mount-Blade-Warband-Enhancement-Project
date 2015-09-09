using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;
using System.Security.Permissions;
using System.IO;

namespace Mount_and_Blade_Installer.Windows.UI
{
    /// <summary>
    /// Interaction logic for Progress.xaml
    /// </summary>
    public partial class Progress : Window
    {
        [HostProtectionAttribute(SecurityAction.LinkDemand, ExternalThreading = true)]
        public Progress( Uri _url, string fileName)
        {
            InitializeComponent();
            Manager( _url, fileName);

        }

        string _filename;

          void Manager(Uri _url,string fileName){
              _filename = fileName;
          WebClient Client = new WebClient();
          Uri url = _url;
              if(File.Exists(@"/"+fileName))
                  File.Delete(@"/" + fileName);


            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Updatebar);
            Client.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(Complete);
            Client.Credentials = System.Net.CredentialCache.DefaultCredentials;
            Client.Headers.Add("Accept: text/html, application/xhtml+xml,*/*");
            Client.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            Client.DownloadFileAsync(url,@"./Assets/7-Zip/"+ fileName);
           
        }
         

        void Updatebar(object sender, DownloadProgressChangedEventArgs e)
        {
            
            Progressbar.Value = e.ProgressPercentage;
            info.Text = e.BytesReceived / 125000 + " Megabit/ " + e.TotalBytesToReceive / 125000+" Megabit";
        }
        void Complete(object sender,System.ComponentModel.AsyncCompletedEventArgs e)
        {
            
            this.Close();
            MessageBox.Show("Download Completed,now installing package.");
            Code.Mods.Unpacker Unpack = new Code.Mods.Unpacker();
            Unpack.RarUnpack  (_filename);
        }

   
    }
}
