using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
   public static  class LibraryFactory
    {
        public static string  Name { get; set; }
        public static string  PhoneNumber { get; set; }
        public static string  Address { get; set; }
       /// <summary>
       /// Creates an user library account
       /// </summary>
       /// <param name="name">Name of the User</param>
       /// <param name="phonenumber">User Phone Number</param>
       /// <param name="address">User Address</param>
       /// <returns>Account Number</returns>
       public static LibraryAccount CreateAccount(string name,string phonenumber,string address)
        {
            LibraryAccount account = new LibraryAccount(name);
            account.PhoneNumber = phonenumber;
            return account;

        }
    }
}
