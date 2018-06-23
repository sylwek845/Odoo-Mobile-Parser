using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooPythonToJava.Wrappers
{
    class OColumnGenerator
    {
        private StringBuilder stringBuilder = new StringBuilder();
        public const string appost = "\"";

               public string GetOColumn(ColumnData columnData)
        {
            if(columnData == null)
            {
                return null;
            }
            AllColumnStart(columnData);

            switch (columnData.Ttype)
            {
                case "char":
                    GenerateStandardOColumn("OVarchar.class");
                    break;
                case "many2one":
                    GenerateM2O(columnData);
                    break;
                case "selection":                    
                    GenerateStandardOColumn("OSelection.class");
                    break;
                case "boolean":
                    GenerateStandardOColumn("OBoolean.class");
                    break;
                case "integer":
                    GenerateStandardOColumn("OInteger.class");
                    break;
                case "date":
                    GenerateStandardOColumn("ODate.class");
                    break;
                case "one2many":
                    GenerateO2M(columnData);
                    break;
                case "text":
                    GenerateStandardOColumn("OText.class");
                    break;
                case "many2many":
                    GenerateM2M(columnData);
                    break;
                case "datetime":
                    GenerateStandardOColumn("ODatetime.class");
                    break;
                case "binary":
                    GenerateStandardOColumn("OBlob.class");
                    break;
                case "float":
                    GenerateStandardOColumn("OFloat.class");
                    break;
                default:
                    return null;
            }
            AddStatementEnd(columnData);
            return stringBuilder.ToString();
        }
        private void AllColumnStart(ColumnData columnData)
        {
            stringBuilder.Clear();
            stringBuilder.Append("\t");
            stringBuilder.Append("private OColumn ");
            stringBuilder.Append(columnData.Name);
            stringBuilder.Append(" = new OColumn(");
            stringBuilder.Append(appost);
            stringBuilder.Append(columnData.Field_description);
            stringBuilder.Append(appost);
            stringBuilder.Append(',');
        }

        private void GenerateStandardOColumn(string javaClassName)
        {
            stringBuilder.Append(javaClassName);
            stringBuilder.Append(")");
        }

        private void AddStatementEnd(ColumnData columnData)
        {
            if (columnData.Required)
            {
                stringBuilder.Append(".setRequired()");
            }            
            stringBuilder.Append(";");
            if (columnData.Ttype == "selection")
            {
                stringBuilder.Append("//TODO - Add Selections");
            }
        }
        private void GenerateO2M(ColumnData columnData)
        {
            stringBuilder.Append(GenerateRelationClassName(columnData.Relation));
            stringBuilder.Append(".class");
            stringBuilder.Append(", OColumn.RelationType.OneToMany)");
            stringBuilder.Append(".setRelatedColumn(");
            stringBuilder.Append(appost);
            stringBuilder.Append(columnData.Relation_field);
            stringBuilder.Append(appost);
            stringBuilder.Append(")");
        }
        private void GenerateM2O(ColumnData columnData)
        {
            stringBuilder.Append(GenerateRelationClassName(columnData.Relation));
            stringBuilder.Append(".class");
            stringBuilder.Append(", OColumn.RelationType.ManyToOne)");
        }
        private void GenerateM2M(ColumnData columnData)
        {
            stringBuilder.Append(GenerateRelationClassName(columnData.Relation));
            stringBuilder.Append(".class");
            stringBuilder.Append(", OColumn.RelationType.ManyToMany)");
        }

        public static string GenerateRelationClassName(string relationOdoo)
        {
            if(relationOdoo == null && relationOdoo == String.Empty)
            {
                return null;
            }
            StringBuilder relationBuilder = new StringBuilder();
            string[] relation = relationOdoo.Split('.');
            for(int i = 0;i < relation.Length; i++)
            {
                relationBuilder.Append(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(relation[i].ToLower()));
            }   
            
            return relationBuilder.ToString();
        }
        
    }
  
}
