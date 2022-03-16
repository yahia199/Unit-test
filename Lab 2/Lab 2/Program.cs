using System;

namespace Lab_2
{
    public class Program
    {
        static public decimal balance = 500;
        static void Main(string[] args)
        {
            try
            {
                UserInterface();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static decimal ViewBalance()
        {
                return balance;
            
        }
        public static decimal Withdraw(decimal withdraw)
        {
            decimal newBalance;
          if(withdraw < 0)
            {
                Console.WriteLine("You can not withdraw less than Zero");
                return balance;
            }
          else if(withdraw > balance)
            {
                Console.WriteLine("Your balnce is not enough");
                return balance;
            }
            else
            {
                newBalance = balance - withdraw;
                balance = newBalance;

                return newBalance;
            }
            
        }
        public static decimal Deposit(decimal deposite) 
        {
            decimal newBalance;
            if (deposite < 0)
            {
                Console.WriteLine("You can not deposite less than Zero");
                return balance;
            }
            else
            {
                newBalance = balance + deposite;
                balance = newBalance;

                return newBalance;
            }
        }

        static void UserInterface() 
        {
            Console.WriteLine("Please insert from 1 to 4");
            Console.WriteLine("1 to show your balance");
            Console.WriteLine("2 to withdrow");
            Console.WriteLine("3 to deposit");
            Console.WriteLine("4 to exit");
            string action = Console.ReadLine();

            bool run = true;
            while (run == true)
            {
                
                switch (action)
                {

                    case "1":
                        Console.WriteLine($"Your balance is  { ViewBalance():C2}");
                        break;

                    case "2":
                        Console.WriteLine("Please inter the value you want to withdrow");
                        String withdrow = Console.ReadLine();
                        decimal value = Convert.ToDecimal(withdrow);
                        Console.WriteLine($"Your balance after withdraw is :  {Withdraw(value):C2} ");
                        break;
                    case "3":
                        Console.WriteLine("Please inter the value you want to deposit");
                        String deposit = Console.ReadLine();
                        decimal depositval = Convert.ToDecimal(deposit);
                        Console.WriteLine($"Your balance after deposit is :{ Deposit(depositval):C2}");
                        break;
                    case "4":
                        run = false;
                        Console.WriteLine("Thank you, Please press any key to exit");                       
                        break;
                    default:
                        Console.WriteLine("Please inter a value from 1 to 4");
                        break;

                }
                action = Console.ReadLine();
               //

            }

        }
    }
    
}

