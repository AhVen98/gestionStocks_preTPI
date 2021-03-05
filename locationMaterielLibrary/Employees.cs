using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using locationMateriel;

namespace locationMateriel
{
    public class Employees:Persons
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string emailAdress;

        public Employees(string firstName, string lastName, DateTime birthDate, string emailAdress): base(firstName, lastName, birthDate, emailAdress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.emailAdress = emailAdress;
        }

        static public bool RentObject(Object objectName)
        {
            bool res = true;
            return res;
        }

        static public bool AddObject(string name, string type, string description, int employeeNumber, string remark = "")
        {
            bool res = RequestDB.AddObject(name, type, description, employeeNumber, remark);
            if (res == true)
            {
                //message que tout a fonctionné
            }
            else
            {
                //message de non-fonctionnement
            }
            //retour à l'accueil
        }

        static public bool ReturnObject(Object objectName)
        {
            bool res = true;
            return res;
        }
    }
}
