namespace Abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            UniBank uniBank = new UniBank("Sanan Ibragimov","2343-2423-5466-6786","455",345.50m);
            Console.WriteLine("My UniBank account:");
            uniBank.Deposit(10);
            uniBank.Withdraw(25);
            Console.WriteLine("---------------------------------------------------------------------------");
            AccessBank accessBank = new AccessBank("Vasif Ibragimov", "2347-3786-5466-6796", "530", 355.60m);
            accessBank.Deposit(3.50m);
            accessBank.Withdraw(11.90m);
            Console.WriteLine("---------------------------------------------------------------------------");
            PashaBank pashaBank = new PashaBank("Vuqar Aliyev", "6543-3796-5466-6796", "710", 150.10m);
            pashaBank.Deposit(3.50m);
            pashaBank.Withdraw(23.70m);
            Console.WriteLine("---------------------------------------------------------------------------");
            LeoBank leoBank = new LeoBank("Amin Zeynalov", "6789-3873-2325-6596", "630", .1m);
            Console.WriteLine("My LeoBank Account:");
            leoBank.Deposit(.9m);
            leoBank.Withdraw(2);
        }
    }
}