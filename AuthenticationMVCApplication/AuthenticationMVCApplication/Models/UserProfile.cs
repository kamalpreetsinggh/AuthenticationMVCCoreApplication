using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationMVCApplication.Models
{
    public class UserProfile
    {
        [Key]
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Role { get; set; }
    }
}
