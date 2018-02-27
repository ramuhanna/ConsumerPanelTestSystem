/*
* Description: This class is part of the Consumer Panel Test System, a Web-Based application utilized for organized and systemized market research process.
* Author: R.M.
* Due date: 27/02/2018
*/

namespace ConsumerPanelTestSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>  
    /// This class contains the link between the program domain and the database.
    /// </summary>

    public partial class ConsumerPanelTestSystemDbContext : DbContext
    {
        public ConsumerPanelTestSystemDbContext()
            : base("name=ConsumerPanelTestSystemDbContext")
        {
        }

        public virtual DbSet<AdditionalQuestion> AdditionalQuestions { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AssignWork> AssignWorks { get; set; }
        public virtual DbSet<BrandManager> BrandManagers { get; set; }
        public virtual DbSet<ContainQuestion> ContainQuestions { get; set; }
        public virtual DbSet<CPTCoordinator> CPTCoordinators { get; set; }
        public virtual DbSet<CPTRequest> CPTRequests { get; set; }
        public virtual DbSet<CRUManager> CRUManagers { get; set; }
        public virtual DbSet<CRUMember> CRUMembers { get; set; }
        public virtual DbSet<CRUSupervisor> CRUSupervisors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EnterResult> EnterResults { get; set; }
        public virtual DbSet<ExecutionLocation> ExecutionLocations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MarketingDirector> MarketingDirectors { get; set; }
        public virtual DbSet<ProgressReport> ProgressReports { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<QuestionnaireType> QuestionnaireTypes { get; set; }
        public virtual DbSet<Requester> Requesters { get; set; }
        public virtual DbSet<ResponsibleFor> ResponsibleFors { get; set; }
        public virtual DbSet<SelectQuestionnaire> SelectQuestionnaires { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasMany(e => e.EnterResults)
                .WithRequired(e => e.Answer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BrandManager>()
                .HasMany(e => e.BFinalizedRequests)
                .WithRequired(e => e.BrandManagerDecision)
                .HasForeignKey(e => e.BDecision)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BrandManager>()
                .HasMany(e => e.SubmittedRequests)
                .WithRequired(e => e.BrandManagerSubmitRequest)
                .HasForeignKey(e => e.BEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BrandManager>()
                .HasMany(e => e.BReveiewedRequests)
                .WithRequired(e => e.BrandManagerReviewRequest)
                .HasForeignKey(e => e.BReviewRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BrandManager>()
                .HasMany(e => e.Questionnaires)
                .WithRequired(e => e.BrandManager)
                .HasForeignKey(e => e.BEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CPTCoordinator>()
                .HasMany(e => e.Answers)
                .WithRequired(e => e.CPTCoordinator)
                .HasForeignKey(e => e.CPTEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CPTCoordinator>()
                .HasMany(e => e.SelectQuestionnaires)
                .WithRequired(e => e.CPTCoordinator)
                .HasForeignKey(e => e.CPTEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CPTRequest>()
                .HasMany(e => e.ExecutionLocations)
                .WithRequired(e => e.CPTRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CPTRequest>()
                .HasMany(e => e.ProgressReports)
                .WithRequired(e => e.CPTRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CPTRequest>()
                .HasMany(e => e.SelectQuestionnaires)
                .WithRequired(e => e.CPTRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUManager>()
                .HasMany(e => e.Answers)
                .WithRequired(e => e.CRUManager)
                .HasForeignKey(e => e.CMAEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUManager>()
                .HasMany(e => e.ProgressReports)
                .WithRequired(e => e.CRUManager)
                .HasForeignKey(e => e.CMAEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUManager>()
                .HasMany(e => e.ResponsibleFors)
                .WithRequired(e => e.CRUManager)
                .HasForeignKey(e => e.CMAEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUMember>()
                .HasMany(e => e.AssignWorks)
                .WithRequired(e => e.CRUMember)
                .HasForeignKey(e => e.CMEEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUMember>()
                .HasMany(e => e.EnterResults)
                .WithRequired(e => e.CRUMember)
                .HasForeignKey(e => e.CMEEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUSupervisor>()
                .HasMany(e => e.Answers)
                .WithRequired(e => e.CRUSupervisor)
                .HasForeignKey(e => e.CSEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUSupervisor>()
                .HasMany(e => e.AssignWorks)
                .WithRequired(e => e.CRUSupervisor)
                .HasForeignKey(e => e.CSEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUSupervisor>()
                .HasMany(e => e.CRUMembers)
                .WithRequired(e => e.CRUSupervisor1)
                .HasForeignKey(e => e.CRUSupervisor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUSupervisor>()
                .HasMany(e => e.ProgressReports)
                .WithRequired(e => e.CRUSupervisor)
                .HasForeignKey(e => e.CSEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRUSupervisor>()
                .HasMany(e => e.ResponsibleFors)
                .WithRequired(e => e.CRUSupervisor)
                .HasForeignKey(e => e.CSEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.BrandManager)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.CPTCoordinator)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.CRUManager)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.CRUMember)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.CRUSupervisor)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.MarketingDirector)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Requester)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ExecutionLocations)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingDirector>()
                .HasMany(e => e.MFinalizedRequests)
                .WithRequired(e => e.MarketingDirectorDecision)
                .HasForeignKey(e => e.MEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingDirector>()
                .HasMany(e => e.MReveiewedRequests)
                .WithRequired(e => e.MarketingDirectorReviewRequest)
                .HasForeignKey(e => e.MReviewRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingDirector>()
                .HasMany(e => e.Questionnaires)
                .WithRequired(e => e.MarketingDirector)
                .HasForeignKey(e => e.MEmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.ContainQuestions)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.EnterResults)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.QuestionnaireTypes)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.AdditionalQuestions)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.AssignWorks)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.ContainQuestions)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.ResponsibleFors)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.SelectQuestionnaires)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requester>()
                .HasMany(e => e.CPTRequests)
                .WithRequired(e => e.Requester)
                .HasForeignKey(e => e.REmployeeID)
                .WillCascadeOnDelete(false);
        }
    }
}
