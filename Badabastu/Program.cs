using System;

namespace BadaBastu
{
    class Program
    {
        static int FarenheitToCelsius(int farenheit)
        {
            int celsius = ((farenheit - 32) * 5) / 9;
            return celsius;
        }
        static void Main(string[] args)
        {

            bool loop = true;
                do
            {
                try
                {
                    Console.WriteLine("Please type in farenheit for convertion to celsius.");
                    int farenheit = Convert.ToInt32(Console.ReadLine());
                    int celsius = FarenheitToCelsius(farenheit);
                    while (celsius < 73 || celsius > 77)
                    {
                        if (celsius < 73)
                        {
                            Console.WriteLine("Det är för kallt för att basta.");
                            farenheit = Convert.ToInt32(Console.ReadLine());
                            celsius = FarenheitToCelsius(farenheit);
                        }

                        else
                        {
                            Console.WriteLine("Det är för varmt för att basta.");
                            farenheit = Convert.ToInt32(Console.ReadLine());
                            celsius = FarenheitToCelsius(farenheit);
                        }

                    }
                    if (celsius == 75)
                    {
                        Console.WriteLine("Perfekt bastu tempratur!");

                    }
                    else
                    {
                        Console.WriteLine("Det går att basta nu!");

                    }


                    Console.ReadKey();
                    loop = false;
                }
                catch
                {
                    Console.WriteLine("Nu gick något galet, försök igen med ett heltal.");
                }
            } while (loop);
        }
    }
}
