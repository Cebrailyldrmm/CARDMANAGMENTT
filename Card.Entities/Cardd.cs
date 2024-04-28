using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Entities
{
    public class Cardd
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cardid { get; set; }
        public Customer customer { get; set; }
        [StringLength(50)]
        public string CardName { get; set; }= string.Empty;
        [StringLength(50)]
        public string Bankname { get; set; } = string.Empty;
        [StringLength(50)]
        public string Cardtybe { get; set; } = string.Empty;
        [StringLength (50)]
        public string cardnumber { get; set; } = string.Empty;

        public int CardMonth { get; set; }

        public int Cardyear { get; set; }

        public int CardCVV { get; set; }

    }
}
