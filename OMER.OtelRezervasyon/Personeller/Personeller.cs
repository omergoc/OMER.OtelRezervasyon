
using MongoDB.Bson;

namespace OMER.OtelRezervasyon.Personeller
{
    public class Personeller
    {
        public ObjectId Id { get; set; }
        public string PersoenlAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelMail { get; set; }
        public string PersonelNo { get; set; }
        public string PersonelSifre { get; set; }
    }
}
