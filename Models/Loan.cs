using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerWPF.Models
{
    public class Loan
    {
        public int Id { get; set; }

        public DateTime? LoanDate { get; set; }

        public DateTime? ExpectedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        public User User { get; set; } = null!;
    }
}
