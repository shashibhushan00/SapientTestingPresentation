using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataModels.Models
{
    public class ApiConfiguration
    {
        [Key]
        public int ApiConfigurationId { get; set; }
        public string ApiPublisher { get; set; }
        public DateTime SchedulingTime { get; set; }
        public virtual List<ApiEndpoint> ApiEndpoints { get; set; }
        public virtual List<Symbol> Symbols { get; set; }
    }
}
