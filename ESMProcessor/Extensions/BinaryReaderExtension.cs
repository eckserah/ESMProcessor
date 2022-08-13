using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMProcessor.Extensions
{
    public static class BinaryReaderExtension
    {
        public static string ReadString(this BinaryReader reader, int size)
        {
            return Encoding.Default.GetString(reader.ReadBytes(size));
        }

        public static string ReadSignature(this BinaryReader reader)
        {
            return ReadString(reader, 4);
        }
    }
}
