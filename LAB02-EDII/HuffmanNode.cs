using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EDII
{
    class HuffmanNode
    {
        public int Data { get; set; }
        public string S { get; set; }

        public HuffmanNode Left;
        public HuffmanNode Right;

        public HuffmanNode(int Data, string S)
        {
            this.Data = Data;
            this.S = S;
        }
    }
}
