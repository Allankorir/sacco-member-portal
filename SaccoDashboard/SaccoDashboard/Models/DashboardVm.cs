namespace SaccoDashboard.Models;

public class DashboardVm
{
    public decimal CurrentSavings { get; set; }
    public decimal LoanTotal { get; set; }
    public decimal LoanRemaining { get; set; }
    public List<decimal> DailyContributions { get; set; } = new();
    public List<string> DailyLabels { get; set; } = new();
    public List<TransactionVm> RecentTransactions { get; set; } = new();
}

public class TransactionVm
{
    public string DateLabel { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Amount { get; set; }
}
