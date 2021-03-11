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

        bool res = true;

        RequestDB req = new RequestDB();

        public Employees(string firstName, string lastName, DateTime birthDate, string emailAdress): base(firstName, lastName, birthDate, emailAdress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.emailAdress = emailAdress;
        }

        
        public void RentObject(string objName, int locator_id, int adder_id, DateTime expectedReturn )
        {
            int objID = req.ReqGetIDFromName(objName);
            req.ReqRentObject(objID, locator_id, adder_id, expectedReturn);
        }

        public void AddObject(string name, string type, string description, int employeeNumber, string remark = "")
        {
            int typeID = req.ReqGetIDFromType(type);
            req.ReqAddObject(name, typeID, description, employeeNumber, remark);
        }

        public void ReturnObject(string name, DateTime returnDate)
        {
            if (res != true)
            {

            }
            else
            {

            }
        }
    }
}
