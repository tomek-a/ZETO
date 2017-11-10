using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class Person
    {
        public Person()
        {

        }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Job { get; set; }
        public int Phone { get; set; }
        public int Mobile { get; set; }

        public virtual Company Company { get; set; }
    }
}
