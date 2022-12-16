using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumac;

namespace Tumac
{
    public enum AccountType { Current, Savings }
    public class BankAccount
    {
        private Queue Transactions = new Queue();
        private long ID;
        private decimal Balance;
        private AccountType Type { get; set; }
        private static HashSet<long> LastID = new HashSet<long>(0);

        public Queue GetTransaction
        {
            get { return Transactions; }
        }
        public BankAccount() { }
        public BankAccount(long ID, decimal Balance, AccountType Type)
        {
            this.ID = ID;
            this.Balance = Balance;
            this.Type = Type;

        }
        public void Print() => Console.WriteLine($"Id: {ID}Баланс: {Balance} Тип: {Type}");
        public void GenerateID()
        {
            Random r = new Random();
            ID = r.Next(0, 228558000);
        }
        public long NewID()
        {
            Random r = new Random();
            ID = r.Next(0, 228558000);
            if (!LastID.Contains(ID))
            {
                ID++;
            }
            return ID;
        }
        public void Add(decimal cash)
        {
            Balance += cash;
            Console.WriteLine($"Ваш Баланс: {Balance}");
            Transactions.Enqueue(new BankTransaction(cash));


        }
        public void Subtract(decimal cash)
        {
            if (Balance > 0)
            {
                if (Balance - cash > 0)
                {
                    Balance -= cash;
                    Console.WriteLine($"Ваш Баланс: {Balance}");
                }
                else
                {
                    Console.WriteLine($"Недостаточно средств :( Ваш Баланс: {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Ошиб0чка(");
            }
            Transactions.Enqueue(new BankTransaction(cash));
        }
        public void Transition(BankAccount acc1, decimal sum)
        {
            if (this.Balance >= sum)
            {
                Balance -= sum;
                acc1.Balance += sum;
                BankTransaction b = new BankTransaction(sum);
                Transactions.Enqueue(b);
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
            
        }
        public void Dispose()
        {
            StreamWriter t = new StreamWriter(@"..\..\..\Library\Text.txt");
            foreach (var i in Transactions)
            {
                t.WriteLine(i.ToString());
            }
            GC.SuppressFinalize(this);
        }

    }
}
