using EczaneHangFire.Jobs;
using EczaneHangFire.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EczaneHangFire.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            EczaneJob.GetPharmacyMonthly(28,22,30);//Her ayın 28 i 10.30 da

            NobetciEczaneJob.GetPharmacyDailyTimeOne(13, 15); //her gün 13.15 te
            NobetciEczaneJob.GetPharmacyDailyTimeTwo(18,15);//her gün 18.15 te
            NobetciEczaneJob.GetPharmacyDailyTimeThree(20, 15);//her gün 20.15 te

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
