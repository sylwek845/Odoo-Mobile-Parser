using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdooPythonToJava.Files_Generators;

namespace OdooPythonToJava.Wrappers.Generators
{
    class XMLAdapterGenerator : SyncProviderGenerator
    {
        private string supportUpload = "true";
        private string userVisible = "true";
        public XMLAdapterGenerator(ConfigData config) : base(config)
        {}

        public override string Generate()
        {
            stringBuilderProvider.Append("<sync-adapter xmlns:android=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("http://schemas.android.com/apk/res/android");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\tandroid:accountType=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(config.PackageName);
            stringBuilderProvider.Append(".auth");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\tandroid:contentAuthority=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(config.Authority);
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\tandroid:supportsUploading=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(supportUpload);
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\tandroid:userVisible=");
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append(userVisible);
            stringBuilderProvider.Append(OColumnGenerator.appost);
            stringBuilderProvider.Append("/>");
            return stringBuilderProvider.ToString();
        }
    }
}
