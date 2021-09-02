using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels.Models
{
    public class ApiEndpoint
    {
        [Key]
        public int ApiEndpointId { get; set; }
        public string ApiEndpointUrl { get; set; }
        public string MethodType { get; set; }
        public string ApiPublisher { get; set; }
        public string Headers { get; set; }
        public string Parameters { get; set; }
        public int ThirdPartyApiId { get; set; }

        [ForeignKey("ThirdPartyApiId")]
        public virtual ApiConfiguration ApiConfigurations { get; set; }
    }
}
