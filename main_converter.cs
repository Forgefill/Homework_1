using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter a = new Converter();
            
            while(true)     // взаємодія з користувачем через консоль
            {
                Console.WriteLine("оберiть валюту в яку ви хочете конвертувати: \nusd - USD\neuro - EURO\nend - вийти з програми");
                string s = Console.ReadLine();
                if(s == "end")
                {
                    break;
                }
                Console.WriteLine("Введiть тип конвертацiї: \nout - uah -> {0}\n in - {0} -> uah", s);
                string ctype = Console.ReadLine();
 
                Console.WriteLine("Введiть кiлькiсть грошей для конвертацiї:");
                string money = Console.ReadLine();
                int amount = int.Parse(money);

                if (s == "usd")
                {
                    if (ctype == "out")
                    {
                        Console.WriteLine("{0} UAH = {1} USD", amount, a.GetUsd()*amount);
                    }
                    else if(ctype == "in")
                    {
                        Console.WriteLine("{0} USD = {1} UAH",amount,amount/a.GetUsd());
                    }
                }
                else if (s == "euro")
                {
                    if (ctype == "out")
                    {
                        Console.WriteLine("{0} UAH = {1} EURO", amount, a.GetEuro() * amount);
                    }
                    else if(ctype == "in")
                    {
                        Console.WriteLine("{0} EURO = {1} UAH", amount, amount / a.GetEuro());
                    }
                }
            }
        }
    }
}
