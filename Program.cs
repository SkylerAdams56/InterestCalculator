namespace Interest_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interset Calculator");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter Loan Amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number of Years: ");
            double years = Convert.ToDouble(Console.ReadLine());

            double interest = (loanAmount * interestRate);
            double total = (loanAmount + interest);
            double monthly = (total/years/12);
            Console.WriteLine("Loan Amount: " + loanAmount);
            Console.WriteLine("Interest Rate: " + interestRate);
            Console.WriteLine("Interest: " + interest);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Monthly: " + monthly);
            Console.WriteLine("Continue? (y/n): ");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}