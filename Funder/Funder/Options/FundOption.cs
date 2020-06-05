using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Funder.Options
{
   public class FundOption
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount2 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount3 { get; set; }
        public DateTime FundDate { get; set; }
        public string Reward { get; set; }
    }
}
