using System;

namespace homeworke
{
    class Program
    {
        struct citizen
        {
            public string name;
            public int pasport;
            public int number_problem;
            public string problem;
            public int scandal;
            public int mind;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ДЗ. Задача 3");
            Console.WriteLine("Окно 1 - оплата" + '\n' + "Окно 2 - подключение" + '\n' + " Окно 3 - отопление");
            Console.WriteLine("Заполните форму клиента");
            citizen Kirill = new citizen();
            Console.WriteLine("Введите имя");
            Kirill.name = Console.ReadLine();
            Console.WriteLine("Введите номер паспорта");
            Kirill.pasport = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер проблемы от 1 до 3");
            Kirill.number_problem = int.Parse(Console.ReadLine());
            Console.WriteLine("Опишите проблему");
            Kirill.problem = Console.ReadLine();
            Console.WriteLine("Введите уровень скандальности. 10 - скандальный урод, 0 - паинька");
            Kirill.scandal = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень развития. 1 - умный, 0 - отсталый");
            Kirill.mind = int.Parse(Console.ReadLine());
            var massiv = Kirill.problem.Split();
            foreach (var word1 in massiv)
            {
                if (word1 == "оплата" || word1 == "Оплата" || word1 == "ОПЛАТА")
                {
                    Console.WriteLine("Вам в 1 окно");
                    break;
                }
                else if (word1 == "подключение" || word1 == "Подключение" || word1 == "ПОДКЛЮЧЕНИЕ")
                {
                    Console.WriteLine("Вам во 2 окно");
                    break;
                }
                else if (word1 == "отопление" || word1 == "Отопление" || word1 == "ОТОПЛЕНИЕ")
                {
                    Console.WriteLine("Вам в 3 окно");
                    break;
                }
            }
            if (Kirill.scandal >= 5)
            {
                Console.WriteLine("Сколько человек из очереди длиной 15 обгонит скандалист?");
                int peoplecount = int.Parse(Console.ReadLine());
                if (peoplecount > 10 || peoplecount < 0)
                {
                    Console.WriteLine("Указано неверное количество людей в очереди");
                }
                else
                {
                    if (Kirill.mind == 0)
                    {
                        Random random = new Random();
                        int room;
                        room = random.Next(1, 3);
                        Console.WriteLine(Kirill.name + " обогнал " + peoplecount + " человек , поэтому теперь он " + (15 - peoplecount) + " в очереди " + '\n' +
                     " ,но " + Kirill.name + " тупой " + " и вместо нужного окна встал в " + room + " окно");
                    }
                    else
                    {
                        Console.WriteLine(Kirill.name + " обогнал " + peoplecount + " человек , поэтому теперь он " + (15 - peoplecount) + " в очереди " + '\n');
                    }
                }
            }
            else
            {
                if (Kirill.mind == 0)
                {
                    Random random = new Random();
                    int room;
                    room = random.Next(1, 3);
                    Console.WriteLine(Kirill.name + " - паинька , но тупой , поэтому вместо своего окна встал в " + room + " окно");
                }
                else
                {
                    Console.WriteLine(Kirill.name + "не тупой, поэтому встал в " + Kirill.number_problem + " окно");
                }
            }

        }
    }
}