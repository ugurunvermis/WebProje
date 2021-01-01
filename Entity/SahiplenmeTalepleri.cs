using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Entity
{
    public class SahiplenmeTalepleri
    {
        public int id { get; set; }
        public virtual Kullanicilar basvuran_kullanici { get; set; }
        public virtual KayitliHayvanlar basvurulan_hayvan { get; set; }
        public virtual SahiplenmeBasvuruDurumlari basvuru_durumu { get; set; }
    }
}
