using System;

namespace NEHO.VABombers.Data.Entities
{
  public class Season
  {
    public int Id { get; set; }
    public string SeasonType { get; set; }
    public DateTime Year { get; set; }
    public string AgeGroup { get; set; }
    public LeagueOrTournament LeagueOrTournament { get; set; }
  }
}