using System.Collections.Generic;

namespace NEHO.VABombers.Data.Entities
{
  public class Roster
  {
    public int Id { get; set; }
    public Season Season { get; set; }
    public List<Player> Players { get; set; }
    public List<PlayerRosterNumbers> PlayerRosterNumbers { get; set; }
  }
}