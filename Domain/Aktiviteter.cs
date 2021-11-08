using System;

namespace Domain
{
    public class Aktiviteter
    {
        public Guid Id { get; set; }

        public string Titel { get; set; }

        public DateTime Dato { get; set; }

        public string Beskrivelse { get; set; }

        public string Kategori { get; set; }

        public string By {get; set;}

        public string Mødested { get; set; }
    }
}