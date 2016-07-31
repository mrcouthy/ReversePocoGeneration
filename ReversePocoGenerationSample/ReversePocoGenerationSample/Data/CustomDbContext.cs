using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ReversePocoGenerationSample.Data
{
    public class CustomDbContext : DbContext
    {
        protected CustomDbContext(DbCompiledModel model) : base(model)
        {
        }
    }
}