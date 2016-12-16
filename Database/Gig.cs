using System;

namespace Schmohawks.Database { 
  public class Gig { 
    public int Id {get;set;}
    public DateTime? StartTime {get;set;}
    public string Description {get;set;}
    public string Venue {get;set;}
    public string City {get;set;}
    public string State {get;set;}
    public bool IsPrivate {get;set;}
  }
}
