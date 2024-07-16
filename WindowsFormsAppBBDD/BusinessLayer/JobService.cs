using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppBBDD.CRUDs;

namespace WindowsFormsAppBBDD.BusinessLayer
{
    public class JobService
    {
        private JobCRUD jobCrud;

        public JobService()
        {
            jobCrud = new JobCRUD();
        }

        public List<jobs> GetJobsList()
        {
            return jobCrud.GetJobsListFromDB();
        }
    }
}
