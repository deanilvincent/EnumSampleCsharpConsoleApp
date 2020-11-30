using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var status = TransactionStatus.ForApproval;
            Console.WriteLine(status.ToString());
        }
    }
}
