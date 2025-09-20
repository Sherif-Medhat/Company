using Comapny.BLL.Interface;
using Company.DAL.Data.Contexts;
using Company.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comapny.BLL.repository
{
    public class DepatrmentRepository : IDepartmentRepository
    {
        private CompanyDbContexts _context;

        public DepatrmentRepository(CompanyDbContexts contexts)
        {
            _context = contexts;
        }
        public int Add(Department model)
        {
            _context.Departments.Add(model);
            return _context.SaveChanges();
        }

        public int delete(Department model)
        {
            _context.Departments.Remove(model);
            return _context.SaveChanges();
        }

        public Department? Get(int id)
        {
            return _context.Departments.Find(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public int update(Department model)
        {
            _context.Departments.Update(model);
            return _context.SaveChanges();
        }
    }
}
