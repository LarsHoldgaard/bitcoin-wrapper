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
    }
}
