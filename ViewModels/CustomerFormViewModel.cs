using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test2.Models;

namespace Test2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}