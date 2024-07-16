using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppBBDD.CRUDs;

namespace WindowsFormsAppBBDD.BusinessLayer
{
    public class EmployeeService
    {
        private EmployeeCRUD employeeCrud;

        public EmployeeService()
        {
            employeeCrud = new EmployeeCRUD();
        }

        public List<employees> GetEmployeeList()
        {
            return employeeCrud.GetEmployeeListFromDB();
        }

        public void InsertEmployee(string first_name, string last_name, string email, string phone_number, DateTime hire_date, int job_id, decimal salary, int? manager_id, int? department_id)
        {
            employees newEmployee = new employees
            {
                first_name = first_name,
                last_name = last_name,
                email = email,
                phone_number = phone_number,
                hire_date = hire_date,
                job_id = job_id,
                salary = salary,
                manager_id = manager_id,
                department_id = department_id
            };

            employeeCrud.InsertEmployeeToDB(newEmployee);
        }
    }
}
