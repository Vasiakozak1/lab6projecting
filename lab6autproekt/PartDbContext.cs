using System.Data.Entity;

namespace lab6autproekt
{
    public class PartDbContext: DbContext
    {
        public DbSet<FirstPartParameters> ParametersForFirstPart { get; set; }
        public DbSet<SecondPartParameters> ParametersForSecondPart { get; set; }
        public DbSet<ThirdPartParameters> ParametersForThird { get; set; }

        public PartDbContext(): base(nameOrConnectionString: "Default")
        {
        }
    }
}
