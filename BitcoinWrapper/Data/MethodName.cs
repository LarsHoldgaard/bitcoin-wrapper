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
        getinfo,
        getpeerinfo,
        getrawmempool,
        getmininginfo,
        backupwallet,
        dumpprivkey,
        encryptwallet,
        getaccountaddress,
        getaddressesbyaccount,
        getblocktemplate,
        getconnectioncount,
        getnewaddress,
        getreceivedbyaccount,
        getreceivedbyaddress,
        gettransaction,
        getwork,
        help,
        listaccounts,
        listaddressgroupings,
        listreceivedbyaccount,
        listreceivedbyaddress,
        listinceblock,
        listtransactions,
        listlockunspent,
        settxfee,
        walletlock
    }
}
