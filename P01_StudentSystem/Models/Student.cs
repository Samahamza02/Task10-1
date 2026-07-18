using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_StudentSystem.Models
{
    public class Student
    {

        public int StudentId { get; set; }
        [MaxLength(100)]
        [Unicode]
        public string Name { get; set; }
        public DateTime? birthday { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? phonenumber { get; set; }  // ? not req ممكن تكون ب null 
        public DateTime RegisteredOn { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
               = new List<StudentCourse>();

        public ICollection<Homework> Homeworks { get; set; }
            = new List<Homework>();


    }
}
