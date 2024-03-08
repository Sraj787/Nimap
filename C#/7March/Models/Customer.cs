using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProboVideo.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public string Address { get; set; }

        [Min18YearCustomer]
        public DateTime BirthDate { get; set; }
        public bool IsSubscribedToNowletter { get; set; }

        public MemberShipTypes memberShipType { get; set; }

        public byte MemberShipTypeId { get; set; }
    }
}