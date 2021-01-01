using System.Collections.Generic;

namespace WebProje.Entity
{
    public class Cinsiyet
    {
        public int id { get; set; }
        public string cinsiyet { get; set; }
        public virtual List<KayitliHayvanlar> hayvanlar { get; set; }
    }
}
