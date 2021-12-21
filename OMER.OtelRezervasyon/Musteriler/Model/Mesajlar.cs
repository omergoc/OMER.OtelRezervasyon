using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace OMER.OtelRezervasyon.Musteriler.Model
{
    class Mesajlar
    {
        public ObjectId Id { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriTC { get; set; }
        public string MusteriTarih { get; set; }
        public string MusteriMesaj { get; set; }
    }
}
