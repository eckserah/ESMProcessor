using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ESMProcessor
{
    class Program
    {
        public Dictionary<>
        static void Main(string[] args)
        {
            string ESMfile = @"T:\F76DataBack\1.4.1.3\SeventySix-1.4.1.3.esm";
            using (BinaryReader br = new BinaryReader(File.OpenRead(ESMfile)))
            { 
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    string Sig = new string(br.ReadChars(4));
                    if (Sig == "TES4")
                    {
                        header = new TESForm(Sig, br);
                    } else if (Sig == "GRUP")
                    {

                    } else
                    {

                    }
                }
            }
        }
    }
}
