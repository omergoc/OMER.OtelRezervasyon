using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace OMER.OtelRezervasyon.Musteriler
{
    class Musteri
    {
        public ObjectId Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Tarih { get; set; }
        public string Adres { get; set; }
        public string Resim { get; set; }

    }
}
