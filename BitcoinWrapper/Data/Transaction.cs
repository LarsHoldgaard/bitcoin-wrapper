using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinWrapper.Data
{
    public class Transaction
    {
        public string HashId { get; set; }
        public decimal Amount { get; set; }

        public Transaction()
        {
            
        }
    }
}
