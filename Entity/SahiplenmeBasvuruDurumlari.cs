using System.Collections.Generic;

namespace WebProje.Entity
{
    public class SahiplenmeBasvuruDurumlari
    {
        public int id { get; set; }
        public string durum { get; set; }
        public virtual List<SahiplenmeTalepleri> talepler { get; set; }
    }
}
