using System.Collections.Generic;

namespace WebProje.Entity
{
    public class BeslenmeProgrami
    {
        public int id { get; set; }
        public string beslenme_programi_adi { get; set; }
        public string sabah { get; set; }
        public string ogle { get; set; }
        public string aksam { get; set; }
        public string gece { get; set; }
        public virtual List<KayitliHayvanlar> hayvanklar { get; set; }
    }
}
