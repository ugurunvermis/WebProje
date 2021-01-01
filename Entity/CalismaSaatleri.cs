namespace WebProje.Entity
{
    public class CalismaSaatleri
    {
        public int id { get; set; }
        public string gun { get; set; }
        public bool durum { get; set; }
        public string acilis_saati { get; set; }
        public string kapanis_saati { get; set; }
        public virtual BarinakBilgileri barinak { get; set; }
    }
}
