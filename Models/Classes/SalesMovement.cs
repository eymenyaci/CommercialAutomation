using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommercialAutomation.Models.Classes
{
    public class SalesMovement
    {
            [Key]
            public int SalesID { get; set; }
            public DateTime SalesDate { get; set; }
            public int SalesUnit { get; set; }
            public decimal SalesPrices { get; set; }
            public decimal SalesTotalPrices { get; set; }
            public Product Product { get; set; }
            public Current Current { get; set; }
            public Staff Staff { get; set; }

      
    }
}