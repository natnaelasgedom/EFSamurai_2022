namespace EFSamurai.Domain
{
    public class Samurai
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Quote> Quotes { get; set; }

        public Hairstyle Hairstyle { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
        public ICollection<SamuraiBattle> SamuraiBattles { get; set; }
    }

}