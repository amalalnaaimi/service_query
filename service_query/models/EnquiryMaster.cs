using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace service_query.models
{
    public class EnquiryMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnquiryId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string MobileNo { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int serviceId { get; set; }
        public DateTime ENQUORYdate { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
