using System.Collections.Generic;

namespace WebProje.Entity
{
    public class HayvanCinsleri
    {
        public int id { get; set; }
        public string hayvan_cinsi { get; set; }
        public string cinsin_genel_ozellikleri { get; set; }
        public virtual HayvanTurleri hayvan_turu { get; set; }
        public virtual List<KayitliHayvanlar> kayitli_hayvanlar { get; set; }
    }
}
