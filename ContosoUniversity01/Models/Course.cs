﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversity01.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Credits { get; set; }
        

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    }
}
