using System.Collections.Generic;

namespace WebProje.Entity
{
    public class KullaniciRolu
    {
        public string id { get; set; }
        public string rol { get; set; }
        public virtual List<Kullanicilar> kullanicilar { get; set; }
    }
}
