using Microsoft.EntityFrameworkCore;

namespace service_query.models
{
    public class EnquiryDbContext : DbContext
    {
        public EnquiryDbContext(DbContextOptions<EnquiryDbContext> options) : base(options)
        {
        }
        public DbSet<EnquiryMaster> EnquiryMasters { get; set; }
        public DbSet<service> services { get; set; }
    }
}
