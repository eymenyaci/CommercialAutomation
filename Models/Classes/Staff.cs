using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommercialAutomation.Models.Classes
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public String StaffName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public String StaffSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(400)]
        public String StaffImage { get; set; }
        public ICollection<SalesMovement> SalesMovements { get; set; }
        public Department Department { get; set; }

    }
}