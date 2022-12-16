using System;

namespace WWWally
{

    public class Program
    {
        public static void Main(string[] args)
        {
            FucktoryBancAccount fucktory = new FucktoryBancAccount();
            fucktory.CreateAccount(228558, 12345, AccountType.Savings, out BankAccount Acc);
            BankAccount ac = fucktory.GetN(228558);
            Console.WriteLine(ac.Equals(Acc));

            FucktoryBuilding.CreateBuild(4, 1, 2, 8);
            FucktoryBuilding.CreateBuild(45, 5, 10, 400);
            FucktoryBuilding.CreateBuild(20, 4, 5,  200);
            FucktoryBuilding.DeleteBuilding(228558);
            foreach (var item in FucktoryBuilding.GetCreatedBuildingsList())
            {
                item.Info();
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
    

}