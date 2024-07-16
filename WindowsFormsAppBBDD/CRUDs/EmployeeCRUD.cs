using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppBBDD.Connection;

namespace WindowsFormsAppBBDD.CRUDs
{
    public class EmployeeCRUD
    {
        private EmployeesDataContext employeesDataContext;

        public EmployeeCRUD()
        {
            employeesDataContext = new EmployeesDataContext();
        }

        public List<employees> GetEmployeeListFromDB()
        {
            List<employees> employees = new List<employees>();

            try
            {
                return employeesDataContext.employees.ToList();
            }
            catch (Exception ex)
            {
                return new List<employees>();
            }
        }

        public void InsertEmployeeToDB(employees newEmployee)
        {
            try
            {
                employeesDataContext.employees.InsertOnSubmit(newEmployee);
                employeesDataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateEmployeeToDB(employees updatedEmployee)
        {

        }
    }
}
