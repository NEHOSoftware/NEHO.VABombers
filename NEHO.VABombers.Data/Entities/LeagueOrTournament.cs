using System;

namespace NEHO.VABombers.Data.Entities
{
  public class LeagueOrTournament
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
  }
}