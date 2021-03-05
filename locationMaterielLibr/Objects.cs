using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using locationMateriel;

namespace locationMateriel
{
    public class Objects
    {
        protected string name;
        protected string description;
        protected DateTime dateAdded;
        protected string state;
        protected string remark;

        public Objects(string name, string description, DateTime dateAdded, string state, string remark="")
        {
            this.name = name;
            this.description= description;
            this.dateAdded = dateAdded;
            this.state = state;
            this.remark = remark;
        }
    }
}
