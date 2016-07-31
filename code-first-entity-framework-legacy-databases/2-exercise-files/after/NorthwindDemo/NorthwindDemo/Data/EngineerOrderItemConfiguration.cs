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
    public partial class EngineerOrderItemConfiguration : EntityTypeConfiguration<EngineerOrderItem>
    {
        public EngineerOrderItemConfiguration()
            : this("dbo")
        {
        }
 
        public EngineerOrderItemConfiguration(string schema)
        {
            ToTable(schema + ".engineer_order_item");
            HasKey(x => x.EngineerOrderItemId);

            Property(x => x.EngineerOrderItemId).HasColumnName("engineer_order_item_id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.EngineerOrderId).HasColumnName("engineer_order_id").IsOptional().HasColumnType("int");
            Property(x => x.Sku).HasColumnName("sku").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);

            HasOptional(a => a.EngineerOrder).WithMany(b => b.EngineerOrderItems).HasForeignKey(c => c.EngineerOrderId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
