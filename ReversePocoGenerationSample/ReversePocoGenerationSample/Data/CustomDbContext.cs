using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace ReversePocoGenerationSample.Data
{
    public class CustomDbContext : DbContext
    {
        protected int SaveChangesCount { get; private set; }

        public CustomDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            
        {
            
        }

        public CustomDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
             
        {
            
        }

        protected CustomDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        protected CustomDbContext(string nameOrConnectionString, DbCompiledModel model)
            : base(nameOrConnectionString, model)
        {
        }

        public override int SaveChanges()
        {
            Console.WriteLine("SaveChanges()");
            ++SaveChangesCount;
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            Console.WriteLine("SaveChangesAsync()");
            ++SaveChangesCount;
            return base.SaveChangesAsync();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("SaveChangesAsync()");
            ++SaveChangesCount;
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}