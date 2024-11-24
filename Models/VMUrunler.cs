namespace RestoranSiparisTakipSistemi.Models
{
    public class VMUrunler
    {
        public int UrunId { get; set; }
        public int KategoriId { get; set; }
        public string? UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public string? Aciklama { get; set; }
        public Urunler? enetity_Urunler { get; set; }
        public List<Urunler>? list_Urunler { get; set; }
    }
}