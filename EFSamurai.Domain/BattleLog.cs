namespace EFSamurai.Domain
{
    public class BattleLog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BattleId { get; set; }
        public Battle Battle { get; set; }
        public ICollection<BattleEvent> BattleEvents { get; set; }
    }

}