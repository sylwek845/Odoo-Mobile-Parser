using CsvHelper;
using OdooPythonToJava.Files_Generators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OdooPythonToJava.Wrappers
{
    class ModuleWrapper
    {
       
        private string inputData;
        private const string moduleNamePref = "_name =";
        private string moduleName = "TODO";
        private string moduleNameJava = "";
        private StringBuilder model;
        StringBuilder oColumns = new StringBuilder();
        private List<string> OColumns;
        private ConfigData configData;


       

        public ModuleWrapper(string pythonModule,ConfigData config)
        {
            this.inputData = pythonModule;
            OColumns = new List<string>();
            model = new StringBuilder();
            this.configData = config;
        }
      
        public string Parse()
        {
            GenerateModelClass();
            return model.ToString();
        }
        private void GenerateOColumns()
        {
            TextReader textReader;
            // textReader = new StringReader(inputData);
            textReader = new StreamReader(new FileStream(inputData, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), Encoding.Default);
            var csv = new CsvReader(textReader);
            csv.Configuration.HeaderValidated = null;
            var records = csv.GetRecords<ColumnData>();

            try
            {
                ColumnData c = records.First();
                moduleName = records.First().Model;
                foreach (var item in records)
                {
                    string col = new OColumnGenerator().GetOColumn(item);
                    if (col != null)
                    {
                        OColumns.Add(col);
                        oColumns.Append(col);
                        oColumns.Append(Environment.NewLine);
                    }
                }

            }
            catch (Exception) { }
        }
        private void GenerateModelClass()
        {
            //Generate OColumns first 
            GenerateOColumns();
            // 

            moduleNameJava = OColumnGenerator.GenerateRelationClassName(moduleName);
            configData.ModuleNameJava = moduleNameJava;
            configData.ModuleNamePython = moduleName;
            if (!configData.IsAuthorityUpdated) { 
                configData.Authority = configData.Authority + "." + moduleName.Replace('.', '_');
                configData.IsAuthorityUpdated = true;
            }

            model.Append("package ");
            model.Append(configData.PackageName);
            model.Append(".addons.");
            model.Append(configData.TargetFolder);
            model.Append(".models;");
            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);
            //
            model.Append("import android.content.Context;");
            model.Append(Environment.NewLine);
            model.Append("import android.net.Uri;");            
            model.Append(Environment.NewLine);
            model.Append("import com.poolpod.core.orm.OModel;");
            model.Append(Environment.NewLine);
            model.Append("import com.poolpod.core.orm.fields.OColumn;");
            model.Append(Environment.NewLine);
            model.Append("import com.poolpod.core.support.OUser;");
            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);
            //
            model.Append("public class ");
            model.Append(moduleNameJava);
            model.Append(" extends OModel {");
            model.Append(Environment.NewLine);
            model.Append("\tpublic static final String TAG = ");
            model.Append(moduleNameJava);
            model.Append(".class.getSimpleName();");
            model.Append(Environment.NewLine);
            model.Append("\tpublic static final String AUTHORITY = ");
            model.Append(OColumnGenerator.appost);
            model.Append(configData.Authority);
            model.Append(OColumnGenerator.appost);
            model.Append(";");

            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);
            //OColumns
            
            model.Append(oColumns);
            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);
            //Constructor
            model.Append("\tpublic "); 
            model.Append(moduleNameJava);
            model.Append("(Context context, OUser user) {");
            model.Append(Environment.NewLine);
            model.Append("\t\tsuper(context, ");
            model.Append(OColumnGenerator.appost);
            model.Append(moduleName);
            model.Append(OColumnGenerator.appost);
            model.Append(", user);}");
            model.Append(Environment.NewLine);
            model.Append(Environment.NewLine);
            //Uri
            model.Append("\t@Override");
            model.Append(Environment.NewLine);
            model.Append("\tpublic Uri uri() {return buildURI(AUTHORITY);}");
            model.Append(Environment.NewLine);
            model.Append("}");
        }

       
        

    }
}
