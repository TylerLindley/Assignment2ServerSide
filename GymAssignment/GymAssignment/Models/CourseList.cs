using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymAssignment.Models
{
    public class CourseList
    {
        [Key]                               //Making a primary key to store all the users in our database. -Tyler Lindley
        public virtual int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")]
        public virtual String CourseName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")]
        public virtual String PhysicalActivity { get; set; }
        [Required]
        public virtual String Time { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")]
        public virtual String Instructor { get; set; }
        [Required]
        public virtual String Location { get; set; }
    }
}
