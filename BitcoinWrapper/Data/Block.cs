using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinWrapper.Data
{
    public class Block
    {
        public string Hash { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Block()
        {
            this.Transactions = new List<Transaction>();
        }
    }
}
