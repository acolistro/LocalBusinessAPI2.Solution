using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;

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

        // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business)
    {
        business.BusinessId = id;
        _db.Entry(business).State = EntityState.Modified;
        _db.SaveChanges();
    }

        // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      _db.Businesses.Remove(businessToDelete);
      _db.SaveChanges();
    }
  }
}