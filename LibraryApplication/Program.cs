using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LibraryAccount myAccount = LibraryFactory.CreateAccount("Madhu", "425-657-988","Redmond");
            Console.WriteLine("Account Number: {0}, Name: {1},Address: {2}", 
            myAccount.AccountNumber, myAccount.UserName,myAccount.Address);

            LibraryFactory.CreateSummary();
            Console.WriteLine(LibraryFactory.CheckOutReport);
        }
    }
}
