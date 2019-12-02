using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymAssignment.Models
{
    public class GymUser : IdentityUser
    {
        public virtual String FavouriteLocation { get; set; }
    }
}
