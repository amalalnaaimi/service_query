namespace service_query.models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class service
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int serviceId { get; set; }
        public string servicename { get; set; } = string.Empty;
        public DateTime createdate { get; set; }
        public bool isactive  { get; set; }
        public double rate { get; set; }
    }
}
