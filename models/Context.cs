using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NotasApi.models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ProfessionalSchool> ProfessionalSchools { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Career> Careers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<QuestionAlternative> QuestionAlternatives { get; set; }
        public DbSet<EvaluationXQuestion> EvaluationXQuestions { get; set; }
        public DbSet<EvaluationAssignment> EvaluationAssignments { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}