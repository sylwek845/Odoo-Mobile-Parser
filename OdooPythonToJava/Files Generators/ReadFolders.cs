using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooPythonToJava.Files_Generators
{
    class ReadFolders
    {
        private ConfigData configData;

        public ReadFolders (ConfigData config)
        {
            this.configData = config;
        }

        public void ReadPackageName()
        {
            string packagePath = configData.ParentFolder + @"\app\src\main\AndroidManifest.xml";
            try
            {
                TextReader textReader = new StreamReader(new FileStream(packagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), Encoding.Default);
                string line;

                while ((line = textReader.ReadLine()) != null)
                {
                    if (line.Contains("package="))
                    {
                        int stIndex = line.IndexOf("package =") + "package =".Length +5;
                        line = line.Remove(0, stIndex);
                        int endIndex = line.IndexOf('"');
                        configData.PackageName = line.Substring(0, endIndex);
                    }
                }


            }
            catch (Exception) { }
        }

    }
}
