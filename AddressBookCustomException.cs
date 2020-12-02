using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookCustomException:Exception
    {
        public AddressBookCustomException()
        {

        }
        public AddressBookCustomException(String message) : base(message)
        {

        }

    }
}
