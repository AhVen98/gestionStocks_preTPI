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
        static public void MethodToCall(string action)
        {
            switch (action)
            {
                case "add":
                    //Employees.AddObject();
                    break;
                case "return":
                    //Employees.ReturnObject();
                    break;
                case "rent":
                    //Employees.RentObject();
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
                    break;
                default:
                    break;
            }
        }
    }
}
