// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace ReversePocoGenerationSample.Context
{
    using ReversePocoGenerationSample.Configuration;
    using ReversePocoGenerationSample.Entities;
    using ReversePocoGenerationSample.Interface;
    using System;


    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class TestDbContext : CustomDbContext, ITestDbContext
    {
        public System.Data.Entity.DbSet<Answer> Answers { get; set; } // Answer
        public System.Data.Entity.DbSet<AnswerComment> AnswerComments { get; set; } // AnswerComment
        public System.Data.Entity.DbSet<Group> Groups { get; set; } // Group
        public System.Data.Entity.DbSet<GroupSurvey> GroupSurveys { get; set; } // GroupSurvey
        public System.Data.Entity.DbSet<MatrixCol> MatrixCols { get; set; } // MatrixCol
        public System.Data.Entity.DbSet<MatrixRow> MatrixRows { get; set; } // MatrixRow
        public System.Data.Entity.DbSet<MenuItem> MenuItems { get; set; } // MenuItem
        public System.Data.Entity.DbSet<OptionChoice> OptionChoices { get; set; } // OptionChoice
        public System.Data.Entity.DbSet<OptionError> OptionErrors { get; set; } // OptionError
        public System.Data.Entity.DbSet<Organization> Organizations { get; set; } // Organization
        public System.Data.Entity.DbSet<PredefinedDropdown> PredefinedDropdowns { get; set; } // PredefinedDropdown
        public System.Data.Entity.DbSet<Question> Questions { get; set; } // Question
        public System.Data.Entity.DbSet<QuestionOption> QuestionOptions { get; set; } // QuestionOption
        public System.Data.Entity.DbSet<QuestionType> QuestionTypes { get; set; } // QuestionType
        public System.Data.Entity.DbSet<Rule> Rules { get; set; } // Rule
        public System.Data.Entity.DbSet<Survey> Surveys { get; set; } // Survey
        public System.Data.Entity.DbSet<SurveyComment> SurveyComments { get; set; } // SurveyComment
        public System.Data.Entity.DbSet<Surveyee> Surveyees { get; set; } // Surveyee
        public System.Data.Entity.DbSet<SurveyeeSurveyComment> SurveyeeSurveyComments { get; set; } // SurveyeeSurveyComment
        public System.Data.Entity.DbSet<SurveySection> SurveySections { get; set; } // SurveySection
        public System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        public System.Data.Entity.DbSet<Tablet> Tablets { get; set; } // Tablet
        public System.Data.Entity.DbSet<User> Users { get; set; } // User
        public System.Data.Entity.DbSet<UserGroup> UserGroups { get; set; } // UserGroup
        public System.Data.Entity.DbSet<UserTablet> UserTablets { get; set; } // UserTablet

        static TestDbContext()
        {
            System.Data.Entity.Database.SetInitializer<TestDbContext>(null);
        }

        public TestDbContext()
            : base("Name=Surveydb")
        {
            InitializePartial();
        }

        public TestDbContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public TestDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public TestDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public TestDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AnswerMapping());
            modelBuilder.Configurations.Add(new AnswerCommentMapping());
            modelBuilder.Configurations.Add(new GroupMapping());
            modelBuilder.Configurations.Add(new GroupSurveyMapping());
            modelBuilder.Configurations.Add(new MatrixColMapping());
            modelBuilder.Configurations.Add(new MatrixRowMapping());
            modelBuilder.Configurations.Add(new MenuItemMapping());
            modelBuilder.Configurations.Add(new OptionChoiceMapping());
            modelBuilder.Configurations.Add(new OptionErrorMapping());
            modelBuilder.Configurations.Add(new OrganizationMapping());
            modelBuilder.Configurations.Add(new PredefinedDropdownMapping());
            modelBuilder.Configurations.Add(new QuestionMapping());
            modelBuilder.Configurations.Add(new QuestionOptionMapping());
            modelBuilder.Configurations.Add(new QuestionTypeMapping());
            modelBuilder.Configurations.Add(new RuleMapping());
            modelBuilder.Configurations.Add(new SurveyMapping());
            modelBuilder.Configurations.Add(new SurveyCommentMapping());
            modelBuilder.Configurations.Add(new SurveyeeMapping());
            modelBuilder.Configurations.Add(new SurveyeeSurveyCommentMapping());
            modelBuilder.Configurations.Add(new SurveySectionMapping());
            modelBuilder.Configurations.Add(new SysdiagramMapping());
            modelBuilder.Configurations.Add(new TabletMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new UserGroupMapping());
            modelBuilder.Configurations.Add(new UserTabletMapping());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AnswerMapping(schema));
            modelBuilder.Configurations.Add(new AnswerCommentMapping(schema));
            modelBuilder.Configurations.Add(new GroupMapping(schema));
            modelBuilder.Configurations.Add(new GroupSurveyMapping(schema));
            modelBuilder.Configurations.Add(new MatrixColMapping(schema));
            modelBuilder.Configurations.Add(new MatrixRowMapping(schema));
            modelBuilder.Configurations.Add(new MenuItemMapping(schema));
            modelBuilder.Configurations.Add(new OptionChoiceMapping(schema));
            modelBuilder.Configurations.Add(new OptionErrorMapping(schema));
            modelBuilder.Configurations.Add(new OrganizationMapping(schema));
            modelBuilder.Configurations.Add(new PredefinedDropdownMapping(schema));
            modelBuilder.Configurations.Add(new QuestionMapping(schema));
            modelBuilder.Configurations.Add(new QuestionOptionMapping(schema));
            modelBuilder.Configurations.Add(new QuestionTypeMapping(schema));
            modelBuilder.Configurations.Add(new RuleMapping(schema));
            modelBuilder.Configurations.Add(new SurveyMapping(schema));
            modelBuilder.Configurations.Add(new SurveyCommentMapping(schema));
            modelBuilder.Configurations.Add(new SurveyeeMapping(schema));
            modelBuilder.Configurations.Add(new SurveyeeSurveyCommentMapping(schema));
            modelBuilder.Configurations.Add(new SurveySectionMapping(schema));
            modelBuilder.Configurations.Add(new SysdiagramMapping(schema));
            modelBuilder.Configurations.Add(new TabletMapping(schema));
            modelBuilder.Configurations.Add(new UserMapping(schema));
            modelBuilder.Configurations.Add(new UserGroupMapping(schema));
            modelBuilder.Configurations.Add(new UserTabletMapping(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
    }
}
// </auto-generated>
