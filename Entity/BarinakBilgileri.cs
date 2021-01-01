using System.Collections.Generic;

namespace WebProje.Entity
{
    public class BarinakBilgileri
    {
        public int id { get; set; }
        public string barinak_adi { get; set; }
        public string barinak_hakkinda { get; set; }
        public string eposta { get; set; }
        public string telefon_numarasi { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string mahalle { get; set; }
        public string adres { get; set; }
        public virtual List<CalismaSaatleri> calisma_saatleri { get; set; }
    }
}
