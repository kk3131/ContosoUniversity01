﻿using System.ComponentModel.DataAnnotations;
namespace ContosoUniversity01.Models

{
    public class Instructor
    {
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstMidName { get; set; } = string.Empty;

        public DateTime HireDate { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstMidName} {LastName}";
        public Department? DepartmentAsAdministrator {  get; set; }
    }
}
