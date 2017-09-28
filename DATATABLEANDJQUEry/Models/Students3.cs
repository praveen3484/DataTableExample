﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DATATABLEANDJQUEry.Models
{
    public class Students3
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FathersName { get; set; }
        public string Standard { get; set; }
        public string Section { get; set; }
        public int Age { get; set; }
        public string HomeAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Contact { get; set; } 
    }
}