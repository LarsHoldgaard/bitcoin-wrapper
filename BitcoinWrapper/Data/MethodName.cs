using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinWrapper.Data
{
    public enum MethodName
    {
        getbalance,
        getblock,
        getrawtransaction,
        decoderawtransaction,
        getaccount,
        getblockcount,
        getblockhash,
        getdifficulty,
        getgenerate,
        gethashespersec,
        getinfo
    }
}
