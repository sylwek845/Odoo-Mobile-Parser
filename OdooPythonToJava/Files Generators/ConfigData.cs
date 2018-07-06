using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooPythonToJava.Files_Generators
{
    class ConfigData
    {
        private Boolean createMissingFolders=true,addToManifest=true, createServicesAndProviders=true, addXMLProvider=true, addBasicListView = false,isAuthorityUpdated = false;
        private string parentFolder,targetFolder,packageName,authority,moduleNamePython,moduleNameJava;

        private static ConfigData configData = null;

        private ConfigData() { }

        public bool CreateMissingFolders { get => createMissingFolders; set => createMissingFolders = value; }
        public bool AddToManifest { get => addToManifest; set => addToManifest = value; }
        public bool CreateServicesAndProviders { get => createServicesAndProviders; set => createServicesAndProviders = value; }
        public bool AddXMLProvider { get => addXMLProvider; set => addXMLProvider = value; }
        public bool AddBasicListView { get => addBasicListView; set => addBasicListView = value; }
        public bool IsAuthorityUpdated { get => isAuthorityUpdated; set => isAuthorityUpdated = value; }
        public string ParentFolder { get => parentFolder; set => parentFolder = value; }
        public string TargetFolder { get => targetFolder; set => targetFolder = value; }
        public string PackageName { get => packageName; set => packageName = value; }
        public string Authority { get => authority; set => authority = value; }
        public string ModuleNamePython { get => moduleNamePython; set => moduleNamePython = value; }
        public string ModuleNameJava { get => moduleNameJava; set => moduleNameJava = value; }

        public static ConfigData GetConfigData()
        {
            if (configData == null)
            {
                configData = new ConfigData();
            }
            return configData;
        }
    }
}
