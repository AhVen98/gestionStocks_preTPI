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
        static public List<Objects> ShowAll()
        {
            List<Objects> lst = new List<Objects>();
            return lst;
        }


        // Method to direct the program to do the right action, depending on the button clicked
        static public void MethodToCall(string action, int employeeNumber = 0, string type="conteneurs", string name="", string description="", string remark="", int locatorNumber = 0)
        {
            frmAddObject add = new frmAddObject();
            frmRentObject rent = new frmRentObject();
            DateTime returnDate = DateTime.Today;

            switch (action)
            {
                case "base":
                   /* List<string> lstTab = new List<string>();
                    string[] row = { };
                    List<Objects> lstObj= Objects.Load();
                    foreach (Objects obj in lstObj)
                    {
                        lstTab.Add(obj.Name);
                        lstTab.Add(obj.State);
                        row = lstTab.ToArray();
                        baseAppli.DgvGlobal.Rows.Add(row);
                    }*/
                    break;
                case "add":
                    Employees.AddObject(name, type, description, employeeNumber, remark);
                    break;
                case "return":
                    Employees.ReturnObject(name, returnDate);
                    break;
                case "rent":
                    Employees.RentObject(name, locatorNumber, employeeNumber, returnDate);
                    break;
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
