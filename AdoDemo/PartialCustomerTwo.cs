using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//part-61 partial classes
namespace AdoDemo
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + ", " + _lastName;
        }
    }
}