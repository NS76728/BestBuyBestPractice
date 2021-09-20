using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyBestPractices
{
    interface IDepartmentRepo
    {
        IEnumerable<Department> GetAllDepartments();
        public void InsertDepartment(string newDepartmentName);


    }
}
