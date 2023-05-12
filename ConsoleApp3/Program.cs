Task t = PrintAsync();
Console.WriteLine("Некоторые действия в методе Main");
t.Wait();

void Print()
{
    Thread.Sleep(3000);
    Console.WriteLine("Hello METANIT.COM");
}

async Task PrintAsync()
{
    Console.WriteLine("Начало метода PrintAsync");
    await Task.Run(() => Print());
    Console.WriteLine("Конец метода PrintAsync");
}