﻿using System;
using System.Collections.Generic;
namespace ContosoUniversity01.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstMidName { get; set; } = string.Empty;

        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
