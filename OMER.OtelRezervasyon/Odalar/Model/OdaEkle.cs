using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMER.OtelRezervasyon.Odalar.Model
{
    public class OdaEkle
    {
        public ObjectId Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
