using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Quotes_App.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public int QuoteId { get; set; }
        [Required]
        public string QuoteText { get; set; }
        [Required]
        public string AuhtorFname { get; set; }
        [Required]
        public string AuthorLname { get; set; }
        public string Subject { get; set; }
        public string Cite { get; set; }
    }
}
