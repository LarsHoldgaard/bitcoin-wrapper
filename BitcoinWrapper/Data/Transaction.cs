using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinWrapper.Data
{
    public class Transaction
    {
        public string TxId { get; set; }
        public int Version { get; set; }
        public int LockTime { get; set; }
        public List<vout> vout { get; set; }
        public List<vin> vin { get; set; }

        public Transaction()
        {
            
        }


    }

    public class vout
    {
        public float value { get; set; }
        public int n { get; set; }
        public scriptPubKey ScriptPubKey { get; set; }
    }

    public class vin
    {
        public string CoinBase { get; set; }
        public string Sequence { get; set; }
           
    }

    public class scriptPubKey
    {
        public string asm { get; set; }
        public string hex { get; set; }
        public string reqSigs { get; set; }
        public string type { get; set; }
        public List<string> addresses { get; set; }
    }
}
