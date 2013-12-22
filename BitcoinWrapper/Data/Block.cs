using System;
using System.Collections.Generic;

namespace BitcoinWrapper.Data
{
    public class Block
    {
        public String Hash { get; set; }
        public Int32 Confirmations { get; set; }
        public Int32 Size { get; set; }
        public Int32 Height { get; set; }
        public Int32 Version { get; set; }
        public String MerkleRoot { get; set; }
        public Double Difficulty { get; set; }
        public String PreviousBlockHash { get; set; }
        public String NextBlockHash { get; set; }
        public String Bits { get; set; }
        public Int32 Time { get; set; }
        public String Nonce { get; set; }

        /// <summary>
        /// This is a list of transaction tx'es
        /// </summary>
        public List<String> Tx { get; set; }

        public Block()
        {
            Tx = new List<String>();
        }
    }
}
