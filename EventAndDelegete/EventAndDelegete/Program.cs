﻿using System;
namespace Work
{
    class Program
    {
        class Account
        {
            public delegate void AccountHandler(Account sender, AccountEventArgs e);
            public static event AccountHandler? Notify;

            public int Sum { get; private set; }

            public Account(int sum) => Sum = sum;

            public void Put(int sum)
            {
                Sum += sum;
                Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
            }
            public void Take(int sum)
            {
                if (Sum >= sum)
                {
                    Sum -= sum;
                    Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
                }
                else
                {
                    Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum));
                }
            }
        }
        class AccountEventArgs
        {
            // Сообщение
            public string Message { get; }
            // Сумма, на которую изменился счет
            public int Sum { get; }
            public AccountEventArgs(string message, int sum)
            {
                Message = message;
                Sum = sum;
            }
        }
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            Account.Notify += DisplayMessage;
            acc.Put(20);
            acc.Take(70);
            acc.Take(150);

            void DisplayMessage(Account sender, AccountEventArgs e)
            {
                Console.WriteLine($"Сумма транзакции: {e.Sum}");
                Console.WriteLine(e.Message);
                Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
            }
        }
    }
}
