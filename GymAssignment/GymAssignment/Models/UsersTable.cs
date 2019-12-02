using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymAssignment.Models
{
    public class UsersTable
    {
        [Key]                               //Making a primary key to store all the users in our database. -Tyler Lindley
        public virtual int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-z""'\s-]*$")]
        public virtual String Name { get; set; }
        [Required]
        [StringLength(255)]
        public virtual String Address { get; set; }
        [Required]
        [StringLength(20)]
        public virtual String PhoneNumber { get; set; }
        public virtual Decimal StartingWeight { get; set; } //Not Required, only if User wants to opt-in with this information, decimal so no rounding errors
        public virtual Decimal GoalWeight { get; set; } //Not Required, only if User wants to opt-in with this information
        [Required]
        [StringLength(100)]
        public virtual String Location { get; set; }
        [StringLength(50)]                  //Not Required, only if User wants to opt-in with this information
        public virtual String PreferredTraining { get; set; }
    }
}
