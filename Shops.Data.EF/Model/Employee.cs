using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Shops.Data.EF.Model
{
    [Table("Employee")]
    public partial class Employee
    {
        public Employee()
        {
            EmployeeShops = new HashSet<EmployeeShop>();
        }

        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Column("TypeID")]
        public int TypeId { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(150)]
        public string Address { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EmploymentDate { get; set; }

        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(EmployeeType.Employees))]
        public virtual EmployeeType Type { get; set; }
        [InverseProperty(nameof(EmployeeShop.Employee))]
        public virtual ICollection<EmployeeShop> EmployeeShops { get; set; }
    }
}
