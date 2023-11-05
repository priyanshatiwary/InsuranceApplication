using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class Document
    {
        [Key]
        public int DocumentId { get; set; } //pk
        public string DocumentType { get; set; } // adhar card, pancard, driving license, passport
        public string DocumentName { get; set; } //name or title of the document
        public string DocumentFile { get; set; } // (doc file datatype e.g., PDF, DOCX, JPG, etc.)
        public bool IsActive { get; set; }       
        public Customer Customer { get; set; } // Navigation property to represent the associated Customer

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}
