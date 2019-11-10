﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailManager.Web.Models
{
    public class LoanApplicationViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public string Phone { get; set; }
        public decimal Amount { get; set; }
        public string EmailId { get; set; }
    }
}