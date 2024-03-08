using ProboVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProboVideo.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipTypes> MemberShipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}