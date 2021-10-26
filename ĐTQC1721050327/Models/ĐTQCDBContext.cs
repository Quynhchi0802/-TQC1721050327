using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ĐTQC1721050327.Models
{
    public partial class ĐTQCDBContext : DbContext
    {
        public ĐTQCDBContext()
            : base("name=ĐTQCDBContext")
        {
        }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public object Person { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
