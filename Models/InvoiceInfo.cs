using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class InvoiceInfo
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(150)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        

        public List<Productdetails> Details { get; set; } = new List<Productdetails>();



    }




    public class Productdetails

    { 
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
       
    }

}