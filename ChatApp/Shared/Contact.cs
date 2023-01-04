using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Shared
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact() { }
        public Contact(int contactId, string firstName, string lastName)
        {
            ContactId = contactId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
