using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppBBDD.Connection;

namespace WindowsFormsAppBBDD.CRUDs
{
    public class JobCRUD
    {
        private EmployeesDataContext employeesDataContext;

        public JobCRUD()
        {
            employeesDataContext = new EmployeesDataContext();
        }

        public List<jobs> GetJobsListFromDB()
        {
            List<jobs> jobs = new List<jobs>();

            try
            {
                return employeesDataContext.jobs.ToList();
            } 
            catch (Exception ex)
            {
                return new List<jobs>();
            }
        }
    }
}
