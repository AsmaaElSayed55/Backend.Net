using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {
        #region Attributes
        private string firstName;
        private string lastName;
        private string country;
        private DateOnly birthDate;
        private string mobileNo;
        #endregion

        #region Properities
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName { get; set; }
        public string Country { get; set; }
        public DateOnly BirthDate { get; set; }
        public string MobileNo { get; set; }

        #endregion

        #region Methods

        public void PrintData()
        {
            Console.WriteLine($"Your Name is {FirstName} {LastName} . \n The Country You live in {Country} . \n Your Birth Date is {BirthDate} .\n Your Mobile Number is {MobileNo} .");
        }
        #endregion
    }
}
