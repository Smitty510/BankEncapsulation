namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
           BankAccount account = new BankAccount();

            Console.WriteLine("How much money do you want to deposit?");
            var userInput = double.Parse(Console.ReadLine());
            account.Deposit(userInput);
            account.GetBalance();
        }
    }
}
