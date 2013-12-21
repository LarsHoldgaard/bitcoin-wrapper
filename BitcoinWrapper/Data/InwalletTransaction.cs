using System;
using System.Collections.Generic;

namespace BitcoinWrapper.Data
{
    public class InwalletTransaction
    {
        public Decimal Amount { get; set; }
        public Int32 Confirmations { get; set; }
        public String Blockhash { get; set; }
        public Int32 BlockIndex { get; set; }
        public Int32 BlockTime { get; set; }
        public String TxId { get; set; }
        public Int32 Time { get; set; }
        public Int32 TimeReceived { get; set; }
        public List<Details> Details { get; set; }
    }

    public class Details
    {
        public String Account { get; set; }
        public String Address { get; set; }
        public String Category { get; set; }
        public Decimal Amount { get; set; }
    }
}
