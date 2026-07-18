using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Models
{
    public class Course
    {
        public int  Courseid { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        [Unicode]
        public string? Description { get; set;  }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public ICollection<Resource> Resources { get; set; }
              = new List<Resource>();

        public ICollection<Homework> Homeworks { get; set; }
            = new List<Homework>();

        public ICollection<StudentCourse> StudentCourses { get; set; }
            = new List<StudentCourse>();
    }


}
