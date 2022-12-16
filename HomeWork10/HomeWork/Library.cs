using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    interface TryStrat
    {
        void Win();
    }
    class Team
    {
        string name;
        string country;
        int countOfPeople;
        int score;
        public Team(string name, string country)
        {
            this.name = name;
            this.country = country;
            countOfPeople = 15;

        }
        public Team(string country)
        {
            name = country;
            this.country = country;
            countOfPeople = 15;
        }
        public string GetTitle
        {
            get { return $"{name}.\tСтрана:{country}.\tКоличество Очков:{score}."; }
        }
        public string GetName
        {
            get { return name; }
        }
        public int GetScore
        {
            get { return score; }
        }
        internal void AddScore(int count = 5)
        {
            score += count;
        }
    }
    interface Games
    {
        public void Beach(Team[] teams);
        public void MouseTrap(Team[] teams);
        public void Sea(Team[] teams);
        public void Fishing(Team[] teams);
        public void Postmen(Team[] teams);
        public void Hill(Team[] teams);
    }
    interface MyGame
    {
        public void Glutton(Team[] teams);
    }

    class BigRaces : Games, MyGame
    {
        string name;
        public BigRaces(string name) { this.name = name; }
        public void PrintResults(Team[] teams)
        {
            foreach (Team team in teams)
            {
                Console.WriteLine(team.GetTitle);
            }
        }
        public void Beach(Team[] teams)
        {
            Random random = new Random();
            int nr = (int)random.Next(0, teams.Length);
            teams[nr].AddScore();
            Console.WriteLine($"Игра: Пляж.\nПобедила Команда:{teams[nr].GetTitle}");
            teams[((nr + 1) % 4)].AddScore(-1);
            Console.WriteLine($"Проиграла Команда:{teams[((nr + 1) % 4)].GetTitle}");
        }
        public void MouseTrap(Team[] teams)
        {
            Random random = new Random();
            int nr = (int)random.Next(0, teams.Length);
            teams[nr].AddScore();
            Console.WriteLine($"Игра: Мышеловка.\nПобедила Команда:{teams[nr].GetTitle}");
            teams[((nr + 1) % 4)].AddScore(-1);
            Console.WriteLine($"Проиграла Команда:{teams[((nr + 1) % 4)].GetTitle}");
        }
        public void Sea(Team[] teams)
        {
            Random random = new Random();
            int nr = (int)random.Next(0, teams.Length);
            teams[nr].AddScore();
            Console.WriteLine($"Игра: Море.\nПобедила Команда:{teams[nr].GetTitle}");
            teams[((nr + 1) % teams.Length)].AddScore(-1);
            Console.WriteLine($"Проиграла Команда:{teams[((nr + 1) % 4)].GetTitle}");
        }
        public void Fishing(Team[] teams)
        {
            Random random = new Random();
            int nr = (int)random.Next(0, teams.Length);
            teams[nr].AddScore();
            Console.WriteLine($"Игра: Рыбалка.\nПобедила Команда:{teams[nr].GetTitle}");
            teams[((nr + 1) % teams.Length)].AddScore(-1);
            Console.WriteLine($"Проиграла Команда:{teams[((nr + 1) % 4)].GetTitle}");
        }
        public void Postmen(Team[] teams)
        {
            Random random = new Random();
            int nr = (int)random.Next(0, teams.Length);
            teams[nr].AddScore();
            Console.WriteLine($"Игра: Почтальоны.\nПобедила Команда:{teams[nr].GetTitle}");
            teams[((nr + 1) % teams.Length)].AddScore(-1);
            Console.WriteLine($"Проиграла Команда:{teams[((nr + 1) % 4)].GetTitle}");
        }
        public void Hill(Team[] teams)
        {
            Random random = new Random();
            int nr = (int)random.Next(0, teams.Length);
            teams[nr].AddScore();
            Console.WriteLine($"Игра: Горка.\nПобедила Команда:{teams[nr].GetTitle}");
            teams[((nr + 1) % teams.Length)].AddScore(-1);
            Console.WriteLine($"Проиграла Команда:{teams[((nr + 1) % 4)].GetTitle}");
        }

        public void Glutton(Team[] teams)
        {
            Random random = new Random();
            int nr = (int)random.Next(0, teams.Length);
            teams[nr].AddScore();
            Console.WriteLine($"Игра: Обжора.\nСамые Большые Обжоры:{teams[nr].GetTitle}");
            teams[((nr + 1) % teams.Length)].AddScore(-1);
            Console.WriteLine($"Слабачки:{teams[((nr + 1) % 4)].GetTitle}");
        }
    }
}
