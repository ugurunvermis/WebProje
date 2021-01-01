using System.Collections.Generic;

namespace WebProje.Entity
{
    public class SaglikDurumu
    {
        public int id { get; set; }
        public bool durum { get; set; } //true sağlıklı -- false hasta
        public virtual List<KayitliHayvanlar> hayvanlar { get; set; }
    }
}