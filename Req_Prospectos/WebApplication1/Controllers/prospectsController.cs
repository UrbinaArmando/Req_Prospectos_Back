using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class prospectsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Prospect> Get()
        {
            using ( var db = new abcContext())
            {
                IEnumerable<Prospect> prospects = db.Prospects.ToList();
                return prospects;
            }
        }
        [HttpPut]
        public IActionResult Update([FromBody] requestUpdate updatedProspect)
        {
            using ( var db = new abcContext())
            {
                var existingProspect = db.Prospects.FirstOrDefault(p => p.id == updatedProspect.Id);
                existingProspect.status = updatedProspect.status;
                existingProspect.comments = updatedProspect.comments;
                db.Update(existingProspect);
                db.SaveChanges();
                return NoContent();
            }
        }
        [HttpPost]
        public IActionResult Create([FromBody] Prospect newProspect)
        {
            using (var db = new abcContext())
            {
                db.Prospects.Add(newProspect);
                db.SaveChanges();

                return NoContent();
            }
        }

    }

    public class requestUpdate
    {
        public int Id { get; set; }
        public string status { get; set; }
        public string comments { get; set; }
    }
}
