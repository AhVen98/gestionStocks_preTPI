using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void RentObject(Object objectName)
        {

        }

        public void AddObject(Object objectName)
        {

        }

        public void ReturnObject(Object objectName)
        {

        }
    }
}
