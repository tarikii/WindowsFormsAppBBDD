using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppBBDD.Connection;

namespace WindowsFormsAppBBDD.CRUDs
{
    public class DepartmentCRUD
    {
        private EmployeesDataContext employeesDataContext;

        public DepartmentCRUD()
        {
            employeesDataContext = new EmployeesDataContext();
        }

        public List<departments> GetDepartmentListFromDB()
        {
            List<departments> departments = new List<departments>();

            try
            {
                return employeesDataContext.departments.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
