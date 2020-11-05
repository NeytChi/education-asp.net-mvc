using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationMvc.Models
{
    [Table("purchase", Schema = "public")]
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public virtual Book Book { get; set; }
    }
}