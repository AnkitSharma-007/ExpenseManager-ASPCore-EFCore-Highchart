using ExpenseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Interfaces
{
    public interface IExpenseService
    {
        IEnumerable<ExpenseReport> GetAllExpenses();
        IEnumerable<ExpenseReport> GetSearchResult(string searchString);
        void AddExpense(ExpenseReport expense);
        int UpdateExpense(ExpenseReport expense);
        ExpenseReport GetExpenseData(int id);
        void DeleteExpense(int id);
        Dictionary<string, decimal> CalculateMonthlyExpense();
        Dictionary<string, decimal> CalculateWeeklyExpense();
    }
}
