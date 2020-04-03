using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusiness.Models;

namespace LocalBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private LocalBusinessContext _db;

    public BusinessesController(LocalBusinessContext db)
    {
      _db = db;
    }

    // GET api/Business
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get()
    {
      return _db.Businesses.ToList();
    }

    // POST api/Business
    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // GET api/animals/5
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id)
    {
        return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }
  }
}