using System.Collections.Generic;

namespace WebProje.Entity
{
    public class KayitliHayvanlar
    {
        public int id { get; set; }
        public string adi { get; set; }
        public int yas { get; set; }
        public string hakkinda { get; set; }
        public virtual HayvanCinsleri cinsi { get; set; }
        public virtual List<HayvanFotograflari> fotograflari { get; set; }
        public virtual Cinsiyet cinsiyeti { get; set; }
        public virtual SaglikDurumu saglik_durumu { get; set; }
        public virtual AsiTakvimi asi_takvimi { get; set; }
        public virtual SahiplenebilirlikDurumu sahiplenebilirlik_durumu { get; set; }
        public virtual BeslenmeProgrami beslenme_programi { get; set; }
        public virtual List<SahiplenmeTalepleri> sahiplenme_basvurulari { get; set; }
    }
}
