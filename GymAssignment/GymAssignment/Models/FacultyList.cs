using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymAssignment.Models
{
    public class FacultyList
    {
        [Key]                               //Making a primary key to store all the users in our database. -Tyler Lindley
        public virtual int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")]
        public virtual String Name { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")]
        public virtual String Shift { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")] //Adding various inputs that we require from each employee
        public virtual String Position { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")]
        public virtual String Department { get; set; }
        [Required]
        public virtual String StoreLocation { get; set; }
        [Required]
        public virtual String HomeAddress { get; set; }
        [Required]
        public virtual String PhoneNumber { get; set; }
    }
}
