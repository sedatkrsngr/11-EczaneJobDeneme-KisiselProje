using EczaneHangFire.Helper;
using EczaneHangFire.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EczaneHangFire.Services
{
    
    public class GetPharmacyServices
    {
        public async static Task GetPharmacyMonthlyServices()//Aylık çalışılınca yapılacak işlem
        {
            BaseAdress _api = new BaseAdress();
            PharmacyList response = new PharmacyList();
            try
            {
                var result = "";

                HttpClient client = _api.httpClient();
            
                HttpResponseMessage res = await client.GetAsync("pharmacy/listnew");
                if (res.IsSuccessStatusCode)
                {
                    result = res.Content.ReadAsStringAsync().Result;
                    response = JsonConvert.DeserializeObject<PharmacyList>(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async static Task GetPharmacyOnDutyDailyServices()//Günlük çalışılınca yapılacak işlem
        {
            BaseAdress _api = new BaseAdress();
            PharmacyList response = new PharmacyList();


            try
            {
                var result = "";

                HttpClient client = _api.httpClient();

                HttpResponseMessage res = await client.GetAsync("pharmacy/getAll");
                if (res.IsSuccessStatusCode)
                {
                    result = res.Content.ReadAsStringAsync().Result;
                    response = JsonConvert.DeserializeObject<PharmacyList>(result);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


