using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooPythonToJava.Files_Generators
{
    class SaveFiles
    {
        private ConfigData configData;
        private string addonsPath;
        private string resPathXML;

        private string xmlAdapter="", xmlManifest="", syncService="", syncProvider="", oModel = "";

        public string OModel { get => oModel; set => oModel = value; }
        public string SyncProvider { get => syncProvider; set => syncProvider = value; }
        public string SyncService { get => syncService; set => syncService = value; }
        public string XmlAdapter { get => xmlAdapter; set => xmlAdapter = value; }

        public SaveFiles(ConfigData configData)
        {
            this.configData = configData;
        }
               
        public void SaveData()
        {
            createAddonsPath();
            createResXMLPath();
            saveOModel();
            saveSyncProvider();
            saveSyncService();
            saveXMLAdapter();
        }
        private void saveOModel()
        {
            System.IO.Directory.CreateDirectory(addonsPath);
            string modelsPath = addonsPath + @"\models";
            System.IO.Directory.CreateDirectory(modelsPath);
            string fileName = modelsPath + @"\" + configData.ModuleNameJava + ".java";
            System.IO.File.WriteAllText(fileName, oModel);
        }
        private void saveSyncProvider()
        {
            System.IO.Directory.CreateDirectory(addonsPath);
            string modelsPath = addonsPath + @"\providers";
            System.IO.Directory.CreateDirectory(modelsPath);
            string fileName = modelsPath + @"\" + configData.ModuleNameJava + "SyncProvider.java";
            System.IO.File.WriteAllText(fileName, syncProvider);
        }
        private void saveSyncService()
        {
            System.IO.Directory.CreateDirectory(addonsPath);
            string modelsPath = addonsPath + @"\services";
            System.IO.Directory.CreateDirectory(modelsPath);
            string fileName = modelsPath + @"\" + configData.ModuleNameJava + "SyncService.java";
            System.IO.File.WriteAllText(fileName, syncService);
        }
        private void saveXMLAdapter()
        {            
            System.IO.Directory.CreateDirectory(resPathXML);
            string fileName = resPathXML + @"\" + configData.ModuleNamePython.Replace(".", "_").ToLower() + "_sync_adapter.xml";
            System.IO.File.WriteAllText(fileName, xmlAdapter);
        }
        private void createAddonsPath()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(configData.ParentFolder);
            stringBuilder.Append(@"\app\src\main\java\");
            stringBuilder.Append(configData.PackageName.Replace(".", @"\").ToLower());
            stringBuilder.Append(@"\addons\");
            stringBuilder.Append(configData.TargetFolder);
            this.addonsPath = stringBuilder.ToString();
        }
        private void createResXMLPath()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(configData.ParentFolder);
            stringBuilder.Append(@"\app\src\main\res\xml");
            this.resPathXML = stringBuilder.ToString();
        }
    }
}
