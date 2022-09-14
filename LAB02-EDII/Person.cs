using System;
using System.Collections.Generic;
using System.Collections;

namespace LAB02_EDII
{
    public class Person
    {
        public string name { get; set; }
        public long dpi { get; set; }
        public DateTime datebirth { get; set; }
        public string address { get; set; }
        public string[] companies { get; set; }

        [NonSerialized]
        public Dictionary<string, string> Keys = new Dictionary<string, string>();
        [NonSerialized]
        public Dictionary<string, BitArray> HuffmanBitArray = new Dictionary<string, BitArray>();
        [NonSerialized]
        public Dictionary<string, string> CodedKeys = new Dictionary<string, string>();
        [NonSerialized]
        public Dictionary<string, string> DecodedKeys = new Dictionary<string, string>();


    }
}
