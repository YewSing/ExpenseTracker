using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        [Key]   //Primary Key
        public int TranscationId { get; set; }

        //CategoryId as foreign key
        public int CategoryId { get; set; }
        public Category? Category { get; set; }    // navigational property
        public int Amount { get; set; }

        [Column(TypeName ="nvarchar(75)")]
        public string? Note { get; set; }

        public DateTime Date {  get; set; } = DateTime.Now;
    }
}
