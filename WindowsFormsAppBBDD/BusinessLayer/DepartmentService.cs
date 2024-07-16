using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppBBDD.CRUDs;

namespace WindowsFormsAppBBDD.BusinessLayer
{
    public class DepartmentService
    {
        private DepartmentCRUD departmentCrud;

        public DepartmentService()
        {
            departmentCrud = new DepartmentCRUD();
        }

        public List<departments> GetDepartmentList()
        {
            return departmentCrud.GetDepartmentListFromDB();
        }
    }
}
