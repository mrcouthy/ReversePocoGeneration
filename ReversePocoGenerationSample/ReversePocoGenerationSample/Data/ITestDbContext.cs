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

namespace ReversePocoGenerationSample.Data
{

    public interface ITestDbContext : System.IDisposable,ISaveChangesCount
    {
        System.Data.Entity.DbSet<Answer> Answers { get; set; } // Answer
        System.Data.Entity.DbSet<AnswerComment> AnswerComments { get; set; } // AnswerComment
        System.Data.Entity.DbSet<Group> Groups { get; set; } // Group
        System.Data.Entity.DbSet<GroupSurvey> GroupSurveys { get; set; } // GroupSurvey
        System.Data.Entity.DbSet<MatrixCol> MatrixCols { get; set; } // MatrixCol
        System.Data.Entity.DbSet<MatrixRow> MatrixRows { get; set; } // MatrixRow
        System.Data.Entity.DbSet<MenuItem> MenuItems { get; set; } // MenuItem
        System.Data.Entity.DbSet<OptionChoice> OptionChoices { get; set; } // OptionChoice
        System.Data.Entity.DbSet<OptionError> OptionErrors { get; set; } // OptionError
        System.Data.Entity.DbSet<Organization> Organizations { get; set; } // Organization
        System.Data.Entity.DbSet<PredefinedDropdown> PredefinedDropdowns { get; set; } // PredefinedDropdown
        System.Data.Entity.DbSet<Question> Questions { get; set; } // Question
        System.Data.Entity.DbSet<QuestionOption> QuestionOptions { get; set; } // QuestionOption
        System.Data.Entity.DbSet<QuestionType> QuestionTypes { get; set; } // QuestionType
        System.Data.Entity.DbSet<Role> Roles { get; set; } // Role
        System.Data.Entity.DbSet<Rule> Rules { get; set; } // Rule
        System.Data.Entity.DbSet<Survey> Surveys { get; set; } // Survey
        System.Data.Entity.DbSet<SurveyComment> SurveyComments { get; set; } // SurveyComment
        System.Data.Entity.DbSet<Surveyee> Surveyees { get; set; } // Surveyee
        System.Data.Entity.DbSet<SurveyeeSurveyComment> SurveyeeSurveyComments { get; set; } // SurveyeeSurveyComment
        System.Data.Entity.DbSet<SurveySection> SurveySections { get; set; } // SurveySection
        System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        System.Data.Entity.DbSet<Tablet> Tablets { get; set; } // Tablet
        System.Data.Entity.DbSet<User> Users { get; set; } // User
        System.Data.Entity.DbSet<UserGroup> UserGroups { get; set; } // UserGroup
        System.Data.Entity.DbSet<UserTablet> UserTablets { get; set; } // UserTablet

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
    }

}
// </auto-generated>