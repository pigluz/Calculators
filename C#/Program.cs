using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            Console.WriteLine("Witaj w kalkulatorze!");
            Thread.Sleep(1000);
            Console.WriteLine("Najpierw zacznijmy od pytań:");

            Console.WriteLine("Jak się nazywasz?");
            string imie = Console.ReadLine();

            Console.WriteLine("Jakie masz nazwisko?");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Ile masz lat?");
            int wiek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gdzie mieszkasz?");
            string miasto = Console.ReadLine();

            Console.WriteLine("Do jakiej szkoły chodzisz?");
            string szkola = Console.ReadLine();

            Console.WriteLine("Dobrze.");
            Thread.Sleep(500);
            Console.WriteLine(
                "Imie: " + imie + "\n" +
                "Nazwisko: " + nazwisko + "\n" +
                "Wiek: " + wiek + "\n" +
                "Miasto: " + miasto + "\n" +
                "Szkoła: " + szkola + "\n"
                );

            Thread.Sleep(1000);
            Console.WriteLine("Czy te dane są poprawne?");
            string wybor = Console.ReadLine();

            if (wybor == "Tak")
            {
                Console.WriteLine("Dobrze! Przejdzmy dalej");
            }
            else
            {
                Console.WriteLine("No to pa. lol...");
                return;
            }
            Thread.Sleep(1000);
            Console.WriteLine("Dobrze " + imie + " Przejdźmy do kalkulatora!");
            Console.WriteLine("Podaj pierwszą liczbą: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj operatora: (+   -   /   *)");
            string oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Twój wynik to" + res);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Twój wynik to:" + res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Twój wynik to:" + res);
                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine("Twój wynik to:" + res);
                    break;
                default:
                    Console.WriteLine("Zły operator! ");
                    break;
            }
        }

    }
}