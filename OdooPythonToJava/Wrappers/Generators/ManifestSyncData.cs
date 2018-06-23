using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdooPythonToJava.Files_Generators;

namespace OdooPythonToJava.Wrappers.Generators
{
    class ManifestSyncData : SyncProviderGenerator
    {
        StringBuilder androidName;
        public ManifestSyncData(ConfigData config) : base(config)
        {        }
       
        public override string Generate()
        {
            androidName = new StringBuilder();
            androidName.Append(config.PackageName);
            androidName.Append(".addons.");
            androidName.Append(config.TargetFolder);
            androidName.Append(".services.");
            androidName.Append(config.ModuleNameJava);
            androidName.Append("Sync");
            ///
            GenerateService();
            GenerateProvider();

            return stringBuilderProvider.ToString();
        }
        private void GenerateProvider()
        {
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t\t\t<provider");
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\tandroid:name=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(androidName.Replace(".services.", ".providers."));
            stringBuilderProvider.Append("Provider");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\tandroid:authorities=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(config.Authority);
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\tandroid:label=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(config.ModuleNameJava);
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\tandroid:multiprocess=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("true");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("/>");
            stringBuilderProvider.Append(Environment.NewLine);
        }
        private void GenerateService()
        {
            stringBuilderProvider.Append("\t\t<service");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t\t\tandroid:name=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(androidName);
            stringBuilderProvider.Append("Service");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\tandroid:exported=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("true");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\tandroid:process=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(":sync_");
            stringBuilderProvider.Append(config.ModuleNameJava);
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(">");
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\t<intent-filter>");
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\t\t<action android:name=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("android.content.SyncAdapter");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("/>");
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\t</intent-filter>");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\t<meta-data");
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\t\tandroid:name=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("android.content.SyncAdapter");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t\t\tandroid:resource=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("@xml/");
            stringBuilderProvider.Append(config.ModuleNamePython.Replace('.', '_'));
            stringBuilderProvider.Append("_sync_adapter");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("/>");
            stringBuilderProvider.Append(Environment.NewLine);
            //
            stringBuilderProvider.Append("\t\t</service>");
            stringBuilderProvider.Append(Environment.NewLine);
        }
        
    }
}


