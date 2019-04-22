using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6autproekt
{
    public class PartDbContext: DbContext
    {
        public DbSet<TestEntity> SomeEntityes { get; set; }

        public PartDbContext(): base(nameOrConnectionString: "Default")
        {
        }
    }
}
