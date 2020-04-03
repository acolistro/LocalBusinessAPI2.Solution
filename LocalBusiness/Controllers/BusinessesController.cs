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
    public ActionResult<ICollection<Business>> Get(int businessId, string name, string manager, int yearJoined, int certNumber, string mainAddress, decimal latitude, decimal longitude, string phone, string email, bool ada)
    {
      var query = _db.Businesses.AsQueryable();

      if (businessId != 0)
      {
        query = query.Where(entry => entry.BusinessId == businessId);
      }


      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }

      if (manager != null)
      {
        query = query.Where(entry => entry.Manager.Contains(manager));
      }    

      if (yearJoined != 0)
      {
        query = query.Where(entry => entry.YearJoined == yearJoined);
      }

      if (certNumber != 0)
      {
        query = query.Where(entry => entry.CertNumber == certNumber);
      }

      if (mainAddress != null)
      {
        query = query.Where(entry => entry.MainAddress == mainAddress);
      }

      if (phone != null)
      {
        query = query.Where(entry => entry.Phone.Contains(phone));
      }

      if (email != null)
      {
        query = query.Where(entry => entry.Email.Contains(email));
      }
      
      return query.ToList();
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