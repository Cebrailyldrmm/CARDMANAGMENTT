using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Entities
{
    public class Customer
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Customerİd { get; set; }
        [StringLength(50)]
        public string  CustomerName { get; set; }=string.Empty;
        [StringLength(50)]
        public string CustomerSurname { get; set; }= string.Empty;
        [StringLength(50)]
        public string CustomerPhone { get; set; } = string.Empty;
        [StringLength(50)]
        public string CustomerTC { get; set; } = string.Empty;
    }
}
