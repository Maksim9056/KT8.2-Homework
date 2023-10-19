namespace KT8._2_Homework
{
  

    class Program
    {
        /// <summary>
        /// Напишите класс BankAccount, который имеет свойство Balance типа decimal и событие типа Action<decimal> с именем BalanceChanged, которое возникает при изменении баланса.
        /// Затем напишите методы Deposit(decimal amount) и Withdraw(decimal amount), которые изменяют баланс на заданную сумму и вызывают событие BalanceChanged. 
        /// Затем напишите класс Logger, который подписывается на это событие и записывает в файл все изменения баланса. 
        /// Продемонстрируйте работу этих классов в методе Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();
            Logger logger = new Logger(account);

            account.BalanceChanged += balance => Console.WriteLine($"Новый баланс: {balance}");

            account.Deposit(1000);
            account.Withdraw(500);

            logger.Dispose();
            Console.ReadLine();
        }
    }

}