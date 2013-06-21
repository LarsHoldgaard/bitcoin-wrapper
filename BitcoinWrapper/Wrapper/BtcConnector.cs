using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitcoinWrapper.Data;
using Newtonsoft.Json;

namespace BitcoinWrapper.Wrapper
{
    public class BtcConnector
    {
        public BaseConnector BaseConnector { get; set; }

        /// <summary>
        /// Starts connecting to the Bitcoin-qt server
        /// </summary>
        public BtcConnector()
        {
            this.BaseConnector = new BaseConnector();
        }

        public decimal GetBalance()
        {
            var result = BaseConnector.RequestServer(MethodName.getbalance)["result"].ToString();
            decimal balance = 0.0m;
            decimal.TryParse(result, out balance);
            return balance;
        }

        public Block GetBlock(string hash)
        {
            Block block = BaseConnector.RequestServer(MethodName.getblock,hash)["result"].ToObject<Block>();
            return block;
        }

        public string GetRawTransaction(string txid)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getrawtransaction,txid)["result"].ToString();
            return rawTransaction;
        }

        public Transaction DecodeRawTransaction(string rawTransaction)
        {
            Transaction transaction = BaseConnector.RequestServer(MethodName.decoderawtransaction, rawTransaction)["result"].ToObject<Transaction>();
            return transaction;
        }


        public string GetAccount(string bitcoinAddress)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getaccount, bitcoinAddress)["result"].ToString();
            return rawTransaction;
        }

        public int GetBlockCount()
        {
            var result = BaseConnector.RequestServer(MethodName.getblockcount)["result"].ToString();
            int balance = 0;
            int.TryParse(result, out balance);
            return balance;
        }
        public string GetBlockhash(int index)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getblockhash,index)["result"].ToString();
            return rawTransaction;
        }
        public decimal GetDifficulty()
        {
            var result = BaseConnector.RequestServer(MethodName.getdifficulty)["result"].ToString();
            decimal balance = 0;
            decimal.TryParse(result, out balance);
            return balance;
        }
        public string GetGenerate()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getgenerate)["result"].ToString();
            return rawTransaction;
        }

        public int GetHashesPerSec()
        {
            var result = BaseConnector.RequestServer(MethodName.gethashespersec)["result"].ToString();
            int balance = 0;
            int.TryParse(result, out balance);
            return balance;
        }
        public string GetInfo()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getinfo)["result"].ToString();
            return rawTransaction;
        }

        public string GetMiningInfo()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getmininginfo)["result"].ToString();
            return rawTransaction;
        }

        public string GetPeerInfo()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getpeerinfo)["result"].ToString();
            return rawTransaction;
        }

        public string GetRawMemPool()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getrawmempool)["result"].ToString();
            return rawTransaction;
        }

        public string BackupWallet(string destination)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.backupwallet,destination)["result"].ToString();
            return rawTransaction;
        }

        public string DumpPrivKey(string bitcoinAddress)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.dumpprivkey, bitcoinAddress)["result"].ToString();
            return rawTransaction;
        }
        public string EncryptWallet(string passphrame)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.encryptwallet,passphrame)["result"].ToString();
            return rawTransaction;
        }
        public string GetAccountAddress(string account)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getaccountaddress,account)["result"].ToString();
            return rawTransaction;
        }
        public string GetAddressesByAccount(string account)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getaddressesbyaccount,account)["result"].ToString();
            return rawTransaction;
        }
        public string GetBlockTemplate()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getblocktemplate)["result"].ToString();
            return rawTransaction;
        }
        public int GetconnectionCount()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getconnectioncount)["result"].ToString();
            int count = 0;
            int.TryParse(rawTransaction, out count);
            return count;
        }
        public string GetNewAddress(string account)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getnewaddress, account)["result"].ToString();
            return rawTransaction;
        }
        public string GetReceivedByAccount(string account)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getreceivedbyaccount,account)["result"].ToString();
            return rawTransaction;
        }

        public string GetReceivedByAddress(string bitcoinAddress)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getreceivedbyaddress, bitcoinAddress)["result"].ToString();
            return rawTransaction;
        }

        public Transaction GetTransaction(string txid)
        {
            Transaction transaction = BaseConnector.RequestServer(MethodName.gettransaction, txid)["result"].ToObject<Transaction>();
            return transaction;
        }

        public string GetWork()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.getwork)["result"].ToString();
            return rawTransaction;
        }

        public string Help()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.help)["result"].ToString();
            return rawTransaction;
        }

        public string ListAccounts()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.listaccounts)["result"].ToString();
            return rawTransaction;
        }

        public string ListAddressGroupings()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.listaddressgroupings)["result"].ToString();
            return rawTransaction;
        }

        public string ListReceivedByAccount()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.listreceivedbyaccount)["result"].ToString();
            return rawTransaction;
        }

        public string ListReceivedByAddress()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.listreceivedbyaddress)["result"].ToString();
            return rawTransaction;
        }

        public string ListInCeBlock()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.listinceblock)["result"].ToString();
            return rawTransaction;
        }

        public string ListTransactions()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.listtransactions)["result"].ToString();
            return rawTransaction;
        }

        public string ListLockUnspent()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.listlockunspent)["result"].ToString();
            return rawTransaction;
        }

        public string SetTxFee(decimal amount)
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.settxfee,amount)["result"].ToString();
            return rawTransaction;
        }
        public string WalletLock()
        {
            var rawTransaction = BaseConnector.RequestServer(MethodName.walletlock)["result"].ToString();
            return rawTransaction;
        }


    }
}
