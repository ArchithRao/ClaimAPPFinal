using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimManageAPI.Models
{
    [Table("Members")]
    public class Members
    {
        [Key]
        public int MId { get; set; }

        [Required]
        [StringLength(100)]
        public string MName { get; set; }

        [Required(ErrorMessage ="Username is required")]
        [StringLength(100,ErrorMessage ="Must be 5 letter or more", MinimumLength = 5)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Must be 5 letter or more", MinimumLength = 5)]
        public string Password { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime DOB { get; set; }
    }
}
