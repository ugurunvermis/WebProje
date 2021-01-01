using System.Collections.Generic;

namespace WebProje.Entity
{
    public class HayvanTurleri
    {
        public int id { get; set; }
        public string hayvan_turu { get; set; }
        public virtual List<HayvanCinsleri> hayvan_cinsleri { get; set; }
    }
}
