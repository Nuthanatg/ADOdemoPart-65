using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//part-61 partial classes
namespace AdoDemo
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
    }
}