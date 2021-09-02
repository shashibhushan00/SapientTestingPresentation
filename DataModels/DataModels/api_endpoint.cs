using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels
{
    public class api_endpoint
    {
        [Key]
        public int api_endpoint_id { get; set; }
        public string apiEndpoint { get; set; }
        public string method_type { get; set; }
        public string api_publisher { get; set; }
        public string headers { get; set; }
        public string parameters { get; set; }
        public int third_party_api_id { get; set; }

        [ForeignKey("third_party_api_id")]
        public virtual api_configuration api_configuration { get; set; }
    }
}
