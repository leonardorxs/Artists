namespace Artists.DAL.Entities
{
    public class ArtistDetail
    {
        public int Id { get; set; }
        public string Talent { get; set; }
        public string Details { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
