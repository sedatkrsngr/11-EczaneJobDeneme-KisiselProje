using EczaneHangFire.Services;
using Hangfire;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EczaneHangFire.Jobs
{
    public class EczaneJob
    {
        public static void GetPharmacyMonthly(int day,int hour,int minute)//Aylık çekilecek işlem
        {
            RecurringJob.AddOrUpdate("AylikEczaneVeriListeleme", () => GetPharmacyServices.GetPharmacyMonthlyServices(), 
                Cron.Monthly(day, hour, minute),TimeZoneInfo.Local);  
        }
    }
}
