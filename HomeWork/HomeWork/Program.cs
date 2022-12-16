using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Market market = new Market() { GetName = "Nikita"};
        market.GetSurname = "Poletaev" ;
        Console.WriteLine(market.GetSurname);
        Console.WriteLine(market.GetName);

    }

}
public class Market
{
    string name;
    string surname;
    string milo;
    public string GetSurname
    {
        get { return $"{surname}"; }
        set { surname = value; }
    }
    public string GetName
    {
        get { return name; }
        init
        {
            name = value;
            milo = $"{name.ToLower()}@mail.su";
        }
    }
}