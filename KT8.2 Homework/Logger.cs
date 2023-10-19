using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8._2_Homework
{
    /// <summary>
    /// Класс Logger
    /// </summary>
    public class Logger
    {
        private StreamWriter writer;

        public Logger(BankAccount account)
        {
            account.BalanceChanged += Account_BalanceChanged;
            writer = new StreamWriter("log.txt");
        }

        private void Account_BalanceChanged(decimal newBalance)
        {
            writer.WriteLine($"Баланс изменен: {newBalance}");
        }

        public void Dispose()
        {
            writer.Close();
        }
    }
}
