﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieCustomerMvcAppWithAuthentication.Models
{
    public class Customer
    {
        public  int Id  { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }

        public string Dob { get; set; }

    }
}