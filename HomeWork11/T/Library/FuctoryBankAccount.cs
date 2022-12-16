using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWally
{
    internal class FucktoryBancAccount
    {
        private Hashtable hashtable = new Hashtable();
        internal long CreateAccount(long ID, decimal Balance, AccountType Type, out BankAccount bankAccount)
        {
            bankAccount = new BankAccount(ID, Balance, Type);
            hashtable[ID] = bankAccount;
            return bankAccount.GetID;
        }
        internal void DeleteAccount(long number)
        {
            try
            {
                hashtable.Remove(hashtable[number]);
            }
            catch
            {
                //Да, он не выбрасывает исключение, так и задумано...
            }
        }
        internal BankAccount GetN(long num)
        {
            return (BankAccount)hashtable[num];
        }
    }
}
