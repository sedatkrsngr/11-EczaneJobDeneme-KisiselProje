using EczaneHangFire.Services;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EczaneHangFire.Jobs
{
    public class NobetciEczaneJob
    {
        public static void GetPharmacyDailyTimeOne(int hour, int minute)//Günlük yapılacak işlem
        {
            RecurringJob.AddOrUpdate("GunlukNöbetciEczaneVeriListelemeOne", () => GetPharmacyServices.GetPharmacyOnDutyDailyServices(), Cron.Daily(hour, minute), TimeZoneInfo.Local);
        }
        public static void GetPharmacyDailyTimeTwo(int hour, int minute)//Günlük yapılacak işlem
        {
            RecurringJob.AddOrUpdate("GunlukNöbetciEczaneVeriListelemeTwo", () => GetPharmacyServices.GetPharmacyOnDutyDailyServices(), Cron.Daily(hour, minute), TimeZoneInfo.Local);
        }
        public static void GetPharmacyDailyTimeThree(int hour, int minute)//Günlük yapılacak işlem
        {
            RecurringJob.AddOrUpdate("GunlukNöbetciEczaneVeriListelemeThree", () => GetPharmacyServices.GetPharmacyOnDutyDailyServices(), Cron.Daily(hour, minute), TimeZoneInfo.Local);
        }

    }
}
