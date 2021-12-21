using MongoDB.Driver;

namespace OMER.OtelRezervasyon
{
    public class Veritabani
    {
        public MongoServer Server;
        public MongoDatabase Database;

        [System.Obsolete]
        public Veritabani()
        {
            string baglanti = "mongodb://localhost";
            Server = MongoServer.Create(baglanti);
            Database = Server.GetDatabase("OMER", SafeMode.True);
        }
    }
}
