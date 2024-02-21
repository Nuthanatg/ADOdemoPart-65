using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//part-61 Partial Classes
namespace AdoDemo
{
    public class Customer
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
        public string GetFullName()
        {
            return _firstName + ", " + _lastName;
        }
    }
}