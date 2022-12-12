using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimManageAPI.Models
{
    [Table("Plans")]
    public class Plans
    {
        [Key]
        [Required(ErrorMessage = "Id is required")]
        public int PId { get; set; }
        [Required(ErrorMessage = "Plan name is required")]
        public string PName { get; set; }
        public double Amount { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        [ForeignKey("Members")]
        public int MrefID { get; set; }
        public Members Mid { get; set; }
    }
}
