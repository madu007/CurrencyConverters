internal class Program
{
    private static void Main(string[] args)
    {
        Currency();
        
        Console.ReadKey();
    }

    public static string Currency()
    {
        string from;
        do
        {

            double amount = 0;
            double converted = 0;
            Console.WriteLine("--------------------");
            Console.WriteLine("Currency convert");
            Console.WriteLine("--------------------");

            Console.WriteLine("How much do you want to convert? : ");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select currency you want to convert: ");
            Console.WriteLine("select conversion direction");
            Console.WriteLine("1:Dollar to Naira");
            Console.WriteLine("2:Naira to Dollar");
            Console.WriteLine("3:Naira to Euro");
            Console.WriteLine("4:Euro to Dollar");
            Console.WriteLine("5:Euro to Naira");
            Console.WriteLine("6:Dollar to Euro");
            Console.WriteLine("Enter selection 1,2,3,4,5,6");

            from = Console.ReadLine();
            if (from == "1")
            {
                converted = (amount * 948);

                Console.WriteLine($"Currency has been converted to:N {converted} Naira");
            }
            else if (from == "2")
            {
                converted = amount / 948;
                Console.WriteLine($"Currency has been convertrd to:$ {converted} Dollars");
            }
            else if (from == "3")
            {
                converted = amount / 980;
                Console.WriteLine($"Currency has been convertrd to:E {converted} Euros");
            }
            else if (from == "4")
            {
                converted = amount / 0.94;
                Console.WriteLine($"Currency has been convertrd to:$ {converted} Dollars");
            }
            else if (from == "5")
            {
                converted = amount * 980;
                Console.WriteLine($"Currency has been convertrd to:N {converted} Naria");
            }
            else if (from == "6")
            {
                converted = amount * 0.94;
                Console.WriteLine($"Currency has been convertrd to:E {converted} Euros");
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
            Console.WriteLine("Would you like to continue? (Y = yes, N = no: )");

        
        } while (Console.ReadLine().ToUpper() == "Y");

        Console.WriteLine("Thanks for using currency converter!");
        return from;
    }

   
}
