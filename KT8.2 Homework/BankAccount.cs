using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8._2_Homework
{
    /// <summary>
    /// Класс BankAccount
    /// </summary>
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set
            {
                balance = value;
                OnBalanceChanged(balance);
            }
        }

        public event Action<decimal> BalanceChanged;

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        protected virtual void OnBalanceChanged(decimal newBalance)
        {
            BalanceChanged?.Invoke(newBalance);
        }
    }
}
