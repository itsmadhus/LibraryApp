using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
   public static  class LibraryFactory
    {
        #region Private
        private static List<LibraryAccount> accounts = new List<LibraryAccount>();

        #endregion

        public static string  Name { get; set; }
        public static string  PhoneNumber { get; set; }
        public static string  Address { get; set; }

        public static string CheckOutReport { get; set; }

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
            accounts.Add(account);
            return account;

        }
        public static void CreateSummary()
        {
            foreach(var account in accounts)
            {
                CheckOutReport += string.Format("Account: {0}, CheckedOutCount: {1}\n", account.AccountNumber, account.CheckedOutCount);
            }

        }
    }
}
