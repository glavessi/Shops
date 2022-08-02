using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Shops.Data.EF.Model
{
    [Table("EmployeeType")]
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [Column("TypeID")]
        public int TypeId { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }

        [InverseProperty(nameof(Employee.Type))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
