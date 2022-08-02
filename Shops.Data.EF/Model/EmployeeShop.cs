using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Shops.Data.EF.Model
{
    [Table("EmployeeShop")]
    public partial class EmployeeShop
    {
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [Column("ShopID")]
        public int ShopId { get; set; }
        [Key]
        [Column(TypeName = "date")]
        public DateTime Workday { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("EmployeeShops")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(ShopId))]
        [InverseProperty("EmployeeShops")]
        public virtual Shop Shop { get; set; }
    }
}
