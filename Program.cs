namespace Topics_1___6_Die_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bet = 1, total;
            bool done = false;
            bool betDone = false;
            string choice;
            Die die1 = new Die();
            Die die2 = new Die();
            total = 100;
            while (!done)
            {
                Console.WriteLine("Welcome to the casino! We just opened so all we have are die games. Let's play!");
                Console.WriteLine("Your current balance is $100");
                Console.WriteLine("How much do you wanna bet");
                while (!betDone)
                {
                    bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > 0 && bet <= total)
                    {
                        betDone = true;
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid bet... Get your money up boy");
                    }
                    while (!done)
                    {


                        Console.WriteLine("What will you bet betting on?");
                        Console.WriteLine("1 - Doubles");
                        Console.WriteLine("2 - Not Doubles");
                        Console.WriteLine("...");
                        Console.WriteLine("3 - Even");
                        Console.WriteLine("4 - Odd");
                        Console.WriteLine();
                        choice = Console.ReadLine().ToLower().Trim();
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Die 1 = {die1}");
                    die1.DrawRoll();
                    Console.WriteLine("Rolling");
                    Thread.Sleep(750);
                    Console.WriteLine($"Die 2 = {die2}");
                    die2.DrawRoll();

                    if (choice = "1")
                    if  (die1.Roll == die2.Roll)
                    {
                        Console.WriteLine("Wow you rolled doubles!");
                        total += bet * 2;
                        Console.WriteLine("Your total now is " + total);
                    }

                    else if ((die1.Roll + die2.Roll) % 2 == 0)
                    {
                        Console.WriteLine("Even sum! Cool");
                        total += bet;
                        Console.WriteLine("Your total now is " + total);
                    }
                    else if ((die1.Roll + die2.Roll) % 2 != 0)
                    {
                        Console.WriteLine("Odd sum! Cool.");
                        total += bet;
                        Console.WriteLine("Your total now is " + total);
                    }

                    else
                    {
                        Console.WriteLine("Tough luck... Thanks for the money");
                        total -= bet;
                        Console.WriteLine("Your total now is " + total);
                    }
                }
            }
        }
    }
}
    


