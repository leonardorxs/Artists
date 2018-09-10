using System;
using System.Collections.Generic;

namespace Artists.DAL.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Site { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual IList<ArtistDetail> Details { get; set; }
    }
}
