using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sep6.Models
{
    public class myproducts
    {
        [Required()]
        public int Prodid { get; set; }
        [MaxLength(10, ErrorMessage = "Product Name cannot be greater than 10 characters")]
        [MinLength(3, ErrorMessage = "Product Name cannot be less than 3 character")]
        public string Prodname { get; set; }
        public int Count { get; set; }



        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime MfgDate { get; set; }
    }
}