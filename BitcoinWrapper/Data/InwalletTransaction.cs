using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinWrapper.Data
{
    public class InwalletTransaction
    {
        public float Amount { get; set; }
        public int Confirmations { get; set; }
        public string Blockhash { get; set; }
        public int BlockIndex { get; set; }
        public int BlockTime { get; set; }
        public string TxId { get; set; }
        public int Time { get; set; }
        public int TimeReceived { get; set; }
        public List<Details> Details { get; set; }

    }

    public class Details
    {
        public string Account { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public float Amount { get; set; }
    }
}
