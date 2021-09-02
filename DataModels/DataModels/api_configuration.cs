using System;
using System.Collections.Generic;

namespace DataModels
{
    public class api_configuration
    {
        public int api_configuration_id { get; set; }
        public string api_publisher { get; set; }
        public DateTime scheduling_time { get; set; }
        public virtual List<api_endpoint> api_endpoints { get; set; }
    }
}
