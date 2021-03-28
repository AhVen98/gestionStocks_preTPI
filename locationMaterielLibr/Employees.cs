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

        
        static public void RentObject(int objID, int locator_id, int adder_id, DateTime expectedReturn )
        {
            RequestDB req = new RequestDB();
            req.ReqRentObject(objID, locator_id, adder_id, expectedReturn);
        }

        static public void AddObject(string name, string type, string description, int employeeNumber, string remark = "")
        {
            RequestDB req = new RequestDB();
            int typeID = req.ReqGetIDFromType(type);
            req.ReqAddObject(name, typeID, description, employeeNumber, remark);
        }

        static public void ReturnObject(int objectNumber)
        {
            RequestDB req = new RequestDB();
            req.ReqReturnObject(objectNumber);

        }

        static public void printPDF(string data)
        {
            RequestDB req = new RequestDB();

            string state;
            if (data == "rented")
            {
                state = "unavailable";
            }
            else
            {
                state = "available";
            }
            req.ReqPDF(state);
        }

        
    }
}
