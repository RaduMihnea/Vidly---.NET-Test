﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        
        [Required]
        public Customer Customer { get; set; }
        
        [Required]
        public Movie Movie { get; set; }
    }
}