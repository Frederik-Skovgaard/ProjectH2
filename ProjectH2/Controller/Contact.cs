using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectH2.Repository.Controller
{
    class Contact
    {
        //Contact name
        public string FullName => $"{firstName} {lastName}";

        private string firstName;
        private string lastName;



        //Address
        public string Address => $"{street}, {streetNr}";

        private string street;
        private int streetNr;



        //Contact information
        public string Linkedin => linkedin;
        public string Phone => phone;
        public string Email => email;

        private string linkedin;
        private string phone;
        private string email;




        /// <summary>
        /// Construtor for adding contact information
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="address"></param>
        /// <param name="addressNr"></param>
        /// <param name="phoneNr"></param>
        /// <param name="emailAddress"></param>
        /// <param name="linkedinLink"></param>
        public Contact(string fName, string lName, string address, int addressNr, string phoneNr, string emailAddress, string linkedinLink)
        {
            //Contact Name
            firstName = fName;
            lastName = lName;

            //Address
            street = address;
            streetNr = addressNr;

            //Contact information
            email = emailAddress;
            phone = phoneNr;
            linkedin = linkedinLink;
        }
        
    }
}
