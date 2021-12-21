using MongoDB.Bson;

namespace OMER.OtelRezervasyon.Odalar.Model
{
    public class OdaKayit
    {
        public ObjectId Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string GirisTarih { get; set; }
        public string CikisTarih { get; set; }
        public string Adres { get; set; }
        public string OdaNo { get; set; }
        public string Fiyat { get; set; }
    }
}
