using System;
using System.Collections.Generic;

namespace BitcoinWrapper.Data
{
    public class Transaction
    {
        public String TxId { get; set; }
        public Int32 Version { get; set; }
        public Int32 LockTime { get; set; }
        public List<Vout> Vout { get; set; }
        public List<Vin> Vin { get; set; }
    }

    public class Vout
    {
        public Decimal Value { get; set; }
        public Int32 n { get; set; }
        public ScriptPubKey ScriptPubKey { get; set; }
    }

    public class Vin
    {
        public String CoinBase { get; set; }
        public String Sequence { get; set; }
    }

    public class ScriptPubKey
    {
        public String asm { get; set; }
        public String hex { get; set; }
        public String reqSigs { get; set; }
        public String type { get; set; }
        public List<String> addresses { get; set; }
    }
}
