using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class QuizContext : DbContext
    {
        public QuizContext() : base("QuizDB")
        {
            Database.SetInitializer(new InitializeDB());
        }
        public DbSet<QuizQuestion> Questions { get; set; }
        public DbSet<QuizAnswer> Answers { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
    public class InitializeDB : DropCreateDatabaseIfModelChanges<QuizContext>
    {
        protected override void Seed(QuizContext context)
        {
            base.Seed(context);
        }
    }
}
