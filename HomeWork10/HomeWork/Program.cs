using System;

namespace Home
{
    public enum Countries
    {
        расия = 0,
        Франция = 1,
        Китай = 2,
        Украина = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            BigRaces bigRaces1 = new BigRaces("Большые Гонки");
            Team Pussia = new Team("Казанские Юлбарсы","расия");
            Team France = new Team("Францизский Багет","Франция");
            Team China = new Team("Китайские Ниндзя","Китай");
            Team Ukraine = new Team("UkraineTeam","Украина");
            Team[] teams = { Pussia, France, China, Ukraine};
            bigRaces1.Beach(teams);
            Console.WriteLine(); Console.ReadKey();
            bigRaces1.MouseTrap(teams);
            Console.WriteLine(); Console.ReadKey();
            bigRaces1.Sea(teams);
            Console.WriteLine(); Console.ReadKey();
            bigRaces1.Fishing(teams);
            Console.WriteLine(); Console.ReadKey();
            bigRaces1.Postmen(teams);
            Console.WriteLine(); Console.ReadKey();
            bigRaces1.Hill(teams);
            Console.WriteLine(); Console.ReadKey();
            Console.WriteLine("Результаты Всех Команд ДО Последней Игры:");
            bigRaces1.PrintResults(teams);
            Console.WriteLine(); Console.ReadKey();
            bigRaces1.Glutton(teams);
            Console.WriteLine(); Console.ReadKey();
            Console.WriteLine("Результаты Всех Команд После Последней Игры:");
            bigRaces1.PrintResults(teams);
            int CountP = 0;
            for(int i = 0; i<teams.Length;i++)
            {
                if(teams[i].GetScore >0)
                    CountP++;
            }
            if(CountP > 1)
            {
                Console.WriteLine("Полуфинал Закончен. Переходим к финалу!");
            }
            Team[] teams1 = new Team[CountP];
            int count = 0;
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i].GetScore > 0)
                {
                    teams1[count] = teams[i];
                    teams1[count].AddScore(-teams1[count].GetScore);
                    count++;
                }
                   
            }
            Console.WriteLine(); Console.ReadKey();
            bigRaces1.Sea(teams1);
            Console.WriteLine(); Console.ReadKey();
            bigRaces1.PrintResults(teams1);
            Console.WriteLine(); Console.ReadKey();

            int max = -10000;
            int index = 0;
            for(int i =0;i<teams1.Length; i++)
            {
                if (teams1[i].GetScore>max)
                {
                    max = teams1[i].GetScore; index = i;
                }
            }
            foreach(Team team in teams1)
            {
                if (team.GetScore == max)
                    Console.WriteLine($"Команда:{team.GetName} Победила!!!");
            }
        }
    }
    
}