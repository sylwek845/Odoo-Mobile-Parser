using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooPythonToJava.Wrappers
{
    class ColumnData
    {
        private string name, relation, ttype, field_description, relation_field, relation_table, model;


        bool required;

        public ColumnData(string name, string relation, string ttype, string field_description, string relation_field, string relation_table,string model, bool required)
        {
            this.Name = name;
            this.Relation = relation;
            this.Ttype = ttype;
            this.Field_description = field_description;
            this.Relation_field = relation_field;
            this.Relation_table = relation_table;
            this.required = required;
            this.model = model;
        }

        
        public bool Required { get => required; set => required = value; }
        public string Name { get => name; set => name = value; }
        public string Relation { get => relation; set => relation = value; }
        public string Ttype { get => ttype; set => ttype = value; }
        public string Field_description { get => field_description; set => field_description = value; }
        public string Relation_field { get => relation_field; set => relation_field = value; }
        public string Relation_table { get => relation_table; set => relation_table = value; }
        public string Model { get => model; set => model = value; }
    }
}
