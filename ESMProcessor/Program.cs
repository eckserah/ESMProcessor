using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ESMProcessor.Extensions;

namespace ESMProcessor
{
    class Program
    {
        public static Dictionary<FormID, BaseFormComponent> FormsList { get; set; }
        public static List<string> ResourceIDList { get; set; }
        public static TESHeader header { get; set; }
        static void Main(string[] args)
        {
            string ESMfile = @"T:\F76DataBack\1.4.1.3\SeventySix-1.4.1.3.esm";
            FormsList = new Dictionary<FormID, BaseFormComponent>();
            ResourceIDList = new List<string>();
            using (BinaryReader br = new BinaryReader(File.OpenRead(ESMfile)))
            { 
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    string Sig = br.ReadSignature();
                    if (Sig == "TES4")
                    {
                        header = new TESHeader(Sig, br);
                        FormsList.Add(0, header);
                    } else if (Sig == "GRUP")
                    {
                        RecordGroup grup = new RecordGroup(Sig, br);
                        Console.WriteLine("Processing group {0}", grup.TrueLabel.ToString());
                        grup.ProcessGrupRecords(ResourceIDList, FormsList);
                    }
                }
            }

            Console.WriteLine("Processed {0} records. Exporting Resource Ids.", FormsList.Count);
            using (FileStream fs = new FileStream(@"T:\F76DataBack\1.4.1.3\ResourceIds.csv", FileMode.OpenOrCreate))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    foreach (string resId in ResourceIDList)
                    {
                        Console.WriteLine("Exporting resource ID info: {0}", resId);
                        sr.WriteLine(resId);
                    }
                }
            }
        }
    }
}
