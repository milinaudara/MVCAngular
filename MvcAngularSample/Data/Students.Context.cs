﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAngularSample.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentsEntities : DbContext
    {
        public StudentsEntities()
            : base("name=StudentsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<ClassStanding> ClassStandings { get; set; }
        public virtual DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public virtual DbSet<CourseOffering> CourseOfferings { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<DegreeLevel> DegreeLevels { get; set; }
        public virtual DbSet<DegreeRequirement> DegreeRequirements { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<DegreeType> DegreeTypes { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<StudentProfile> StudentProfiles { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
    }
}
