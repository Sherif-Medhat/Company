using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Models
{
    internal class Employee : BaseEntity
    {
        public string Address { get; set; }
        public int Salary { get; set; }
    }
}
