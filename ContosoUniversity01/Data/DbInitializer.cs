﻿using ContosoUniversity01.Models;
using ContosoUniversity01.Data;
using System;
using System.Linq; // << 必加這個
namespace ContosoUniversity.Data
{
    //Instructors Departments
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Students.Any())
            {
                return; // DB has been seeded
            }
            var departments = new Department[]
            {
                new Department{Name="Coomputer Science",Budget=50000,StartDate=DateTime.Parse("2025-05-06"),},
                new Department{Name="Mathematics",Budget=30000,StartDate=DateTime.Parse("2025-05-06")},
                new Department{Name="Phsics",Budget=40000,StartDate=DateTime.Parse("2025-05-06")}
            };
            foreach (Department d in departments)
            {
                context.Department.Add(d);
            }
            context.SaveChanges();

            var instructors = new Instructor[]
           {
                new Instructor { FirstMidName = "John", LastName = "Smith", HireDate = DateTime.Parse("2020-09-15") },
                new Instructor { FirstMidName = "Jane", LastName = "Johnson", HireDate = DateTime.Parse("2019-03-01") }
           };
            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            context.SaveChanges();

            var students = new Student[]
            {
                new Student { FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") },
                new Student { FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2003-09-01") },
                new Student { FirstMidName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2001-09-01") },
                new Student { FirstMidName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2003-09-01") },
                new Student { FirstMidName = "Nino", LastName = "Olivetto", EnrollmentDate = DateTime.Parse("2005-09-01") }
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 },
                new Course { CourseID = 4022, Title = "Microeconomics", Credits = 3 },
                new Course { CourseID = 4041, Title = "Macroeconomics", Credits = 3 },
                new Course { CourseID = 1045, Title = "Calculus", Credits = 4 },
                new Course { CourseID = 3141, Title = "Trigonometry", Credits = 4 },
                new Course { CourseID = 2021, Title = "Composition", Credits = 3 },
                new Course { CourseID = 2042, Title = "Literature", Credits = 4 }
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment { StudentID = 1, CourseID = 1050, Grade = Grade.A },
                new Enrollment { StudentID = 1, CourseID = 4022, Grade = Grade.C },
                new Enrollment { StudentID = 1, CourseID = 4041, Grade = Grade.B },
                new Enrollment { StudentID = 2, CourseID = 1045, Grade = Grade.B },
                new Enrollment { StudentID = 2, CourseID = 3141, Grade = Grade.F },
                new Enrollment { StudentID = 2, CourseID = 2021, Grade = Grade.F },
                new Enrollment { StudentID = 3, CourseID = 1050 },
                new Enrollment { StudentID = 4, CourseID = 1050 },
                new Enrollment { StudentID = 4, CourseID = 4022, Grade = Grade.F },
                new Enrollment { StudentID = 5, CourseID = 4041, Grade = Grade.C },
                new Enrollment { StudentID = 6, CourseID = 1045 },
                new Enrollment { StudentID = 7, CourseID = 3141, Grade = Grade.A }
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
