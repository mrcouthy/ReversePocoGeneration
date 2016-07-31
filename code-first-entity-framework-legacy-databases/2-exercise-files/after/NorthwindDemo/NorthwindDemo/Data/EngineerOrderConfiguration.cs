// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using CodeFirstStoreFunctions;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace NorthwindDemo.Data
{
    public partial class EngineerOrderConfiguration : EntityTypeConfiguration<EngineerOrder>
    {
        public EngineerOrderConfiguration()
            : this("dbo")
        {
        }
 
        public EngineerOrderConfiguration(string schema)
        {
            ToTable(schema + ".engineer_order");
            HasKey(x => x.EngineerOrderId);

            Property(x => x.EngineerOrderId).HasColumnName("engineer_order_id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.EngineerId).HasColumnName("engineer_id").IsRequired().HasColumnType("int");
            Property(x => x.OrderPlaced).HasColumnName("order_placed").IsRequired().HasColumnType("datetime");

            HasRequired(a => a.Engineer).WithMany(b => b.EngineerOrders).HasForeignKey(c => c.EngineerId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
