using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Models
{
    internal class BaseEntity
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
