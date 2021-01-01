namespace WebProje.Entity
{
    public class HayvanFotograflari
    {
        public int id { get; set; }
        public string fotograf_adi { get; set; }
        public virtual KayitliHayvanlar hayvan { get; set; }
    }
}
