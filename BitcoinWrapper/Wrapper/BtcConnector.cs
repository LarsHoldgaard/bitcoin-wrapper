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



        //        getaccount,
        //getblockcount,
        //getblockhash,
        //getdifficulty,
        //getgenerate,
        //gethashespersec,
        //getinfo
    }
}
