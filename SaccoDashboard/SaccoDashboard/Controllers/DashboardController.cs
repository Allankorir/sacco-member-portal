using Microsoft.AspNetCore.Mvc;
using SaccoDashboard.Models;

namespace SaccoDashboard.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        var vm = new DashboardVm
        {
            CurrentSavings = 15450.75m,
            LoanTotal = 154000m,
            LoanRemaining = 3200m,
            DailyLabels = new() { "30", "80", "81", "60", "50", "80", "20" },
            DailyContributions = new() { 50, 120, 900, 450, 700, 800, 1200 },
            RecentTransactions = new()
            {
                new() { DateLabel="LAST/2017", Description="Contice Mection", Amount=2500.00m },
                new() { DateLabel="LAST/2017", Description="Conte Band Artiction", Amount=3000.00m },
                new() { DateLabel="LAST/2018", Description="Corttion Nerar", Amount=3700.00m },
            }
        };

        return View(vm);
    }
}
