using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinWrapper.Data
{
    public class Block
    {
        public string Hash { get; set; }
        public int Confirmations { get; set; }
        public int Size { get; set; }
        public int Height { get; set; }
        public int Version { get; set; }
        public string MerkleRoot { get; set; }
        public float Difficulty { get; set; }
        public string PreviousBlockHash { get; set; }
        public string NextBlockHash { get; set; }
        public string Bits { get; set; }
        public int Time { get; set; }
        public string Nonce { get; set; }

        /// <summary>
        /// This is a list of transaction tx'es
        /// </summary>
        public List<string> Tx { get; set; }

        public Block()
        {
            this.Tx = new List<string>();
        }
    }
}
