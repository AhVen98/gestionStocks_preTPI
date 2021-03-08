using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locationMateriel;

namespace locationMateriel
{
    public class Controller
    {



        // Method to direct the program to do the right action, depending on the button clicked
        static public void MethodToCall(string action, int employeeNumber = 0, string type="conteneurs", string name="", string description="", string remark="", DateTime returnDate = DateTime.Today, int locatorNumber = 0)
        {
            Employees emp = new Employees("default", "default", DateTime.Today, "default");
            frmAddObject add = new frmAddObject();
            frmRentObject rent = new frmRentObject();
            

            switch (action)
            {
                case "add":
                    emp.AddObject(name, type, description, employeeNumber, remark);
                    break;
                case "return":
                    emp.ReturnObject(name, returnDate);
                    break;
                case "rent":
                    emp.RentObject(name, locatorNumber, employeeNumber, returnDate);
                    break;
                case "delay":
                    /** todo */
                    break;
                case "logs":
                    /** todo */
                    break;
                case "pdf":
                    /** todo */
                    break;
                case "research":
                    /** todo */
                    break;
                case "cancel":
                    /** todo */
                    frmAddObject.ActiveForm.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
