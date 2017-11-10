﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class Company
    {
        public Company()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int NIP { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Code { get; set; }
        public int Phone { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Person> Person { get; set; } 
    }
}
