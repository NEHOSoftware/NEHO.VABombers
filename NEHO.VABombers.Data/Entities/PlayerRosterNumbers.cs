namespace NEHO.VABombers.Data.Entities
{
  public class PlayerRosterNumbers
  {
    public int PlayerId { get; set; }
    public Player Player { get; set; }
    public int RosterId { get; set; }
    public Roster Roster { get; set; }
    public int JerseyNumber { get; set; }
  }
}