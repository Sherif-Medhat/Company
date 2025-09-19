using Company.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comapny.BLL.Interface
{
    internal interface  IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department? Get(int id);

        int Add(Department model);

        int update(Department model);

        int delete(Department model);


    }
}
