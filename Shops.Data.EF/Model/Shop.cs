using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Shops.Data.EF.Model
{
    [Table("Shop")]
    public partial class Shop
    {
        public Shop()
        {
            EmployeeShops = new HashSet<EmployeeShop>();
        }

        [Key]
        [Column("ShopID")]
        public int ShopId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }

        [InverseProperty(nameof(EmployeeShop.Shop))]
        public virtual ICollection<EmployeeShop> EmployeeShops { get; set; }
    }
}
