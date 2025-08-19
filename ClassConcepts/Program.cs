using System.Dynamic;

namespace ClassConcepts;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount();
        account1.Deposit(100);
        Console.WriteLine(account1.GetBalance());
        

        BankAccount account2 = new BankAccount();
        account2.Deposit(200);
        Console.WriteLine(account2.GetBalance());

        Console.WriteLine(MathHelper.Add(2,3));
    }
}






class BankAccount
{
    decimal balance = 0;

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }

}


class MathHelper
{


    public static int Add(int a, int b)
    {

        return a + b;

    }





}