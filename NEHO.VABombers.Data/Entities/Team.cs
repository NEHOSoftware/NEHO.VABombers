using System.Collections.Generic;

namespace NEHO.VABombers.Data.Entities
{
  public class Team
  {
    public int Id { get; set; }
    public List<Roster> Rosters { get; set; }
  }
}