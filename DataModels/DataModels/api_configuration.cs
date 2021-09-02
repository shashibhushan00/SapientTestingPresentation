using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class api_configuration
    {
        [Key]
        public int api_configuration_id { get; set; }
        public string api_publisher { get; set; }
        public DateTime scheduling_time { get; set; }
        public virtual List<api_endpoint> api_endpoints { get; set; }
    }
}
