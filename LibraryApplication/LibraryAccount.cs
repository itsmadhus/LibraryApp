using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    /// <summary>
    /// Creating enum for type of Books
    /// </summary>
    public enum TypeofBooks
    {
        Technical,
        Fiction,
        Kids
    }
    public enum Section 
    {
        Books,
        Magazines,
        Videos,
        Music
    }
    class LibraryAccount
    {
        /// <summary>
        /// Defines the Library Account for a User.
        /// Allows the User to Checkout and Checkin Books 
        /// </summary>

        #region Variables
        private static int lastAccountNumber = 0;
        private int  CheckedOutBooks = 0;
        int TotalBooks = 100;

        #endregion

        #region Properties
        /// <summary>
        /// User Account
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// User Name
        /// </summary>
        public string  UserName { get; set; }
        /// <summary>
        /// User Phone Number
        /// </summary>
        public string  PhoneNumber { get; set; }
        /// <summary>
        /// User Address
        /// </summary>
        public string Address { get; set; }
        public TypeofBooks Books { get; set; }
        public Section ResourceType { get; set; }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public LibraryAccount()
        {
            AccountNumber = ++lastAccountNumber;
        }
        /// <summary>
        /// Overloaded Constructor to create an user account
        /// by taking user name alone.
        /// </summary>
        /// <param name="name">User Name</param>
        public LibraryAccount(string name)
        {
            AccountNumber = ++lastAccountNumber;
            UserName = name;
           
        }
        /// <summary>
        /// Overlaoded Constructor  to create an user acoount 
        /// by taking user name and user phone number
        /// </summary>
        /// <param name="name">User Name</param>
        /// <param name="phonenumber">User Phone Number</param>
        public LibraryAccount(string name,string phonenumber)
        {
            AccountNumber = ++lastAccountNumber;
            UserName = name;
            PhoneNumber = phonenumber;
        }
        #endregion
        #region Methods
        /// <summary>
        /// This Method is used to checkin books to the library account.
        /// </summary>
        /// <param name="NumberofBooks">Number of Books to be Checked In</param>
        public void Checkin(int NumberofBooks)
        {
               
        }
        /// <summary>
        /// This method is used to checkout books from the library account.
        /// Throws an exception if number of books to be checked 
        /// out is greater than total number of Books available.
        /// </summary>
        /// <param name="NumberofBooks">Number of Books to be checked out</param>
        public void Checkout(int NumberofBooks)
        {
            
            if(NumberofBooks>TotalBooks)
            {
                throw new ArgumentException("No. of Books exceeded Total Books");
            }

            TotalBooks = TotalBooks - NumberofBooks;

        }
        #endregion


    }
}
