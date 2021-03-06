using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        [Required]
        public String ExpenseName { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Amount must be greather than 0")]
        public int Amount { get; set; }
        [DisplayName("ExpenseType")]
        public int ExpenseTypeId { get; set; }
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }
}
}
