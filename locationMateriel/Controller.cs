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
        static public void MethodToCall(string action, int employeeNumber = 0, string type="conteneurs", string name="", string description="", string remark="", int locatorNumber = 0)
        {
            switch (action)
            {

                case "delay":
                    /** todo */
                    break;
                case "logs":
                    /** todo */
                    break;
                case "pdf_rented":
                    break;
                case "pdf_available":
                    /** todo */
                    break;
                case "research":
                    /** todo */
                    break;
                default:
                    break;
            }
        }
    }
}
