using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels.Models
{
    public class UserGridView
    {
        [Key]
        public string EmailId { get; set; }
        public string GridViewEncoding { get; set; }
        public string GridViewName { get; set; }

        [ForeignKey("EmailId")]
        public virtual User Users { get; set; }
    }
}
