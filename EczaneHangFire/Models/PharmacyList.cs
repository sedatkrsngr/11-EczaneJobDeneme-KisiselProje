using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EczaneHangFire.Models
{
    public class PharmacyList
    {
        public string status { get; set; }
        public string message { get; set; }
        public int systemTime { get; set; }
        public int rowCount { get; set; }
        public List<Pharmacy> data { get; set; }
    }
    public class Pharmacy
    {
        public string EczaneAdi { get; set; }
        public string Adresi { get; set; }
        public string Semt { get; set; }
        public string YolTarifi { get; set; }
        public string Telefon { get; set; }
        public string Sehir { get; set; }
        public string ilce { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string EklenmeTarihi { get; set; }
    }
}
