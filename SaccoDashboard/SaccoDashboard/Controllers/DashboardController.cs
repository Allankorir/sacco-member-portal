using Microsoft.AspNetCore.Mvc;
using SaccoDashboard.Models;

namespace SaccoDashboard.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        var vm = new DashboardVm
        {
            CurrentSavings = 155450.75m,
            LoanTotal = 154000m,
            LoanRemaining = 32500m,
            DailyLabels = new() { "30", "80", "81", "60", "50", "80", "20" },
            DailyContributions = new() { 50, 120, 900, 450, 700, 800, 1200 },
            RecentTransactions = new()
            {
                new() { DateLabel="27 Jan 2026", Description="Monthly Contribution", Amount=25000.00m },
                new() { DateLabel="24 Jan 2026", Description="Loan Repayment", Amount=30000.00m },
                new() { DateLabel="20 Jan 2026", Description="Share Deposit", Amount=37500.00m },
                new() { DateLabel="18 Jan 2026", Description="Withdrawal - Member Savings", Amount=15000.00m },
                new() { DateLabel="15 Jan 2026", Description="Statement Fee", Amount=2000.00m },
            }
        };

        return View(vm);
    }
}
