using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Quanda.Models
{
    public class QuandaDbContext: DbContext
    {
        public QuandaDbContext(DbContextOptions<QuandaDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new List<Question>() {
                    new Question {
                        QuestionId = 1,
                        QuestionTitle = "First Question",
                        QuestionText = "About First Question",
                        Created = DateTime.Now,
                        Edited = DateTime.Now 
                    },
                    new Question {
                        QuestionId = 2,
                        QuestionTitle = "Second Question",
                        QuestionText = "About Second Question",
                        Created = DateTime.Now,
                        Edited = DateTime.Now 
                    }
                }
            );
        }

        public DbSet<Question> Questions { get; set; }
    }
}