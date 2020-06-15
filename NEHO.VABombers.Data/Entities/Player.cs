using System.Collections.Generic;

namespace NEHO.VABombers.Data.Entities
{
  public class Player : Person
  {
    public List<Team> Teams { get; set; }
  }
}