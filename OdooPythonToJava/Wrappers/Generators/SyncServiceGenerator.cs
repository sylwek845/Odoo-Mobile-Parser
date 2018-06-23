using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdooPythonToJava.Files_Generators;

namespace OdooPythonToJava.Wrappers.Generators
{
    class SyncServiceGenerator : SyncProviderGenerator
    {
        public SyncServiceGenerator(ConfigData config) : base(config)
        {
        }

        public override string Generate()
        {

            StringBuilder model = new StringBuilder();
            model.Append("package ");
            model.Append(config.PackageName);
            model.Append(".addons.");
            model.Append(config.TargetFolder);
            model.Append(".services;");
            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);
            //
            model.Append(Environment.NewLine);
            model.Append("import com.poolpod.core.support.OUser;");

            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);


            string className = config.ModuleNameJava + "SyncService";
            stringBuilderProvider.Append(model);
            stringBuilderProvider.Append("public class ");
            stringBuilderProvider.Append(className);
            stringBuilderProvider.Append(" extends OSyncService {");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\tpublic static final String TAG = ");
            stringBuilderProvider.Append(className);
            stringBuilderProvider.Append(".class.getSimpleName();");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t@Override");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t public OSyncAdapter getSyncAdapter(OSyncService service, Context context) {");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t\treturn new OSyncAdapter(context, ");
            stringBuilderProvider.Append(config.ModuleNameJava);
            stringBuilderProvider.Append(".class, service, true);");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t}");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t@Override");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\tpublic void performDataSync(OSyncAdapter adapter, Bundle extras, OUser user) {");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t\tadapter.syncDataLimit(50);");
            stringBuilderProvider.Append(Environment.NewLine);
            stringBuilderProvider.Append("\t}");
            stringBuilderProvider.Append("}");
            return stringBuilderProvider.ToString();
        }
    }
}
