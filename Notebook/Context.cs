using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class DataContext : DbContext
    {
        public DataContext() : base("NotebookDB")
        {
            
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
