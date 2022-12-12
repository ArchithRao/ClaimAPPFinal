using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimManageAPI.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int LId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(100, ErrorMessage = "Must be 5 letter or more", MinimumLength = 5)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Must be 5 letter or more", MinimumLength = 5)]
        public string Password { get; set; }
        public Members Mid { get; set; }
    }
}
