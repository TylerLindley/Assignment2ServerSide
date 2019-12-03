using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymAssignment.Models
{
    public class TimeOffSchedule
    {
        [Key]                               //Making a primary key to store all the users in our database. -Tyler Lindley
        public virtual int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")]
        public virtual String Name { get; set; }
        [Required]
        public virtual String Date { get; set; }
        public virtual String CoveredBy { get; set; } //Optional if employee wants to switch or have someone cover their shift
        public virtual DateTime PostTime { get; set; } = DateTime.Now;
    }
}
