using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerWPF.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string? ISBN { get; set; }

        public DateTime? PublicationDate { get; set; }

        public string? Description { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
