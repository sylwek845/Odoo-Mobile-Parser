using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdooPythonToJava.Files_Generators;

namespace OdooPythonToJava.Wrappers
{
    class SyncProviderGenerator
    {
        protected ConfigData config;
        protected StringBuilder stringBuilderProvider;

        public SyncProviderGenerator(ConfigData config)
        {
            this.config = config;
            stringBuilderProvider = new StringBuilder();
        }
        public virtual string Generate()
        {

            StringBuilder model = new StringBuilder();
            model.Append("package ");
            model.Append(config.PackageName);
            model.Append(".addons.");
            model.Append(config.TargetFolder);
            model.Append(".providers;");
            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);
            //
            model.Append("import ");
            model.Append(config.PackageName);
            model.Append(".core.orm.provider.BaseModelProvider;");
            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);

            string className = config.ModuleNameJava + "SyncProvider";
            stringBuilderProvider.Append(model);
            stringBuilderProvider.Append("public class ");
            stringBuilderProvider.Append(className);
            stringBuilderProvider.Append(" extends BaseModelProvider {");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\tpublic static final String TAG = ");
            stringBuilderProvider.Append(className);
            stringBuilderProvider.Append(".class.getSimpleName();");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t@Override");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t public String authority() {");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t\treturn ");
            stringBuilderProvider.Append(config.ModuleNameJava);
            stringBuilderProvider.Append(".AUTHORITY;");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t}");
            stringBuilderProvider.Append("}");
            return stringBuilderProvider.ToString();
        }
    }
}
