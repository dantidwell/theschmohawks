using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using Schmohawks.Database;
using Schmohawks.Models;

namespace WebApplication.Controllers {
  public class HomeController : Controller {
    private readonly IEnumerable<Gig> _gigs = new List<Gig>() {
      new Gig() {
        StartTime = new DateTime(2016, 12, 17), 
        Description = "Wedding", 
        Venue = "Avon Theater", 
        City = "Birmingham", 
        State = "AL", 
        IsPrivate = true
      },
      new Gig() {
        StartTime = new DateTime(2016, 12, 28), 
        Description = "Birmingham Bowl Pep Rally", 
        Venue = "Uptown", 
        City = "Birmingham", 
        State = "AL", 
        IsPrivate = false
      },
      new Gig() {
        StartTime = new DateTime(2016, 12, 31), 
        Description = "Wedding", 
        Venue = "The Club", 
        City = "Birmingham", 
        State = "AL", 
        IsPrivate = true
      }
    };

    public IActionResult Index() {
      var vm = new HomeViewModel() { 
        Gigs = _gigs.OrderBy(g => g.StartTime).Take(3).Select(g => new GigViewModel() {
          Description = g.IsPrivate ? "Private Event" : g.Description, 
          Venue = g.Venue, 
          City = g.City, 
          State = g.State,
          StartTime = g.StartTime
        }).ToList()
      };
      return View(vm);
    }
  }
}
  // public class Gig { 
  //   public int Id {get;set;}
  //   public DateTime? StartTime {get;set;}
  //   public string Name {get;set;}
  //   public string Venue {get;set;}
  //   public string VenueCity {get;set;}
  //   public string VenueState {get;set;}
  //   public bool IsPrivate {get;set;}
  // }