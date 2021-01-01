using System.Collections.Generic;

namespace WebProje.Entity
{
    public class Kullanicilar
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string eposta { get; set; }
        public string sifre { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string mahalle { get; set; }
        public string adres { get; set; }
        public virtual KullaniciRolu kullanici_rolu { get; set; }
        public virtual List<SahiplenmeTalepleri> basvuru_talepleri { get; set; }
    }
}
