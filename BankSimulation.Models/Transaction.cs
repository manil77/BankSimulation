using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TransactionType { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        [ForeignKey("User")]
        public int AccountNumber { get; set; }
        public User User { get; set; }
    }
}
