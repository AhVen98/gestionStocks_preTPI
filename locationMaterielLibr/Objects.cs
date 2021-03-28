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
        protected string type;
        protected string renter;
        protected DateTime expectedReturn;
        protected string state;
        protected int iD;


        public Objects(string name, string type, string state, int ID, DateTime dateReturn, string renter = "")
        {
            this.name = name;
            this.type = type;
            this.renter = renter;
            this.expectedReturn = dateReturn;
            this.state = state;
            this.iD = ID;
        }
        public Objects(string name, string type, string state, int ID)
        {
            this.name = name;
            this.type = type;
            this.state = state;
            this.iD = ID;
        }

        static public List<Objects> Load()
        {
            RequestDB req = new RequestDB();
            List<Objects> lstObj = req.getObjects();
            return lstObj;

        }
        public string Name { get { return name; } }
        public string State { get { return state; } }
        public int ID { get { return iD; } }
        public string Type { get { return type; } }
        public DateTime ExpectedReturn { get { return expectedReturn; } }
        public string Renter { get { return renter; } }

    }
}

