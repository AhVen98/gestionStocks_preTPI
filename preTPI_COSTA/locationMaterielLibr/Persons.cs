using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using locationMateriel;

namespace locationMateriel
{
    public class Persons
    {
        protected string firstName;
        protected string lastName;
        protected DateTime birthdate;
        protected string emailAdress;

        public Persons(string firstName, string lastName, DateTime birthdate, string emailAdress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.emailAdress = emailAdress;
        }
    }
}
