using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using service_query.models;

namespace service_query.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceMasterController : ControllerBase
    {
        private readonly EnquiryDbContext _context;
        public ServiceMasterController(EnquiryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<service> getAllServices()
        {
            var services = _context.services.ToList();
            return services;
        }
        [HttpPost]
        public IActionResult addNewService(service obj)
        {
            _context.services.Add(obj);
            _context.SaveChanges();
            return Ok("Service Added Successfully");

        }
        [HttpPut]
        public IActionResult updateService(int serviceId, servic obj)
        {
            var existingService = _context.service.SingleOrDefault(s => s.serviceId == serviceId);
            if (existingService == null)
            {
                return NotFound("Service not found");
            }
            else
            {
               existingService.servicename = obj.servicename;
                existingService.isactive = obj.isactive;
                _context.SaveChanges();
                return Ok("Service Added Successfully");

            }

        }


    }
}
