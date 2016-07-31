using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePocoGenerationSample.Data
{
    public partial class TestDbContext : ISaveChangesCount
    {
        public int GetSaveChangesCount()
        {
            return SaveChangesCount;
        }
    }

    public partial class FakeTestDbContext : ISaveChangesCount
    {
        public int GetSaveChangesCount()
        {
            return SaveChangesCount;
        }
    }
}
