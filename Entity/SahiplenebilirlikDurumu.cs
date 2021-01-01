using System.Collections.Generic;

namespace WebProje.Entity
{
    public class SahiplenebilirlikDurumu
    {
        public int id { get; set; }
        public bool durum { get; set; }
        public virtual List<KayitliHayvanlar> hayvanlar { get; set; }
    }
}