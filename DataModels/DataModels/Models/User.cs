using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataModels.Models
{
    public class User
    {
        [Key]
        public string EmailId { get; set; }
        public bool UserRole { get; set; }
        public virtual List<UserGridView> UserGridViews { get; set; }
    }
}
