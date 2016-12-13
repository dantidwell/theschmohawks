using System;

namespace Schmohawks.Models {
  public class GigViewModel {
    public string Description { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Venue { get; set; }
    public DateTime? StartTime { get; set; } 
  }
}