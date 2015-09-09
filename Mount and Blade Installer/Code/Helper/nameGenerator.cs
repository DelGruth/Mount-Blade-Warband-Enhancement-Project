using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mount_and_Blade_Installer.Code.Helper
{
    class nameGenerator
    {
        public void Determine(string _filepath,string extraPath)
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory+"/contents.txt");
            string filepath = _filepath;
            int i = 0;
            foreach(var file in Directory.GetFiles( filepath))
            {
                i++;
                string name = file;
               name = name.Replace(Environment.CurrentDirectory+extraPath, "");
                sw.WriteLine(@""""+name+@""""+" ,");
            }
            sw.Close();
        }

    }
}
