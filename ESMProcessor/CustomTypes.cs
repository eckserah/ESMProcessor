using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMProcessor
{
    public struct FormID : IComparable, IFormattable, IComparable<uint>, IComparable<FormID>, IEquatable<uint>
    {
        private uint m_value;

        public const uint MaxValue = 4294967295u;
        public const uint MinValue = 0u;

        private FormID(uint formId)
        {
            m_value = formId;
        }

        public static implicit operator uint(FormID formId)
        {
            return formId.m_value;
        }

        public static implicit operator FormID(uint value) => new FormID(value);
        public static implicit operator FormID(ushort value) => new FormID(value);

        public int CompareTo(object value)
        {
            if (value == null)
                return 1;

            if (value is FormID)
                return CompareTo((uint)value);
            else if (value is uint)
                return CompareTo(value);

            throw new ArgumentException("Not an uint32");
        }

        public int CompareTo(uint value)
        {
            if (m_value < value)
            {
                return -1;
            }
            if (m_value > value)
            {
                return 1;
            }
            return 0;
        }

        public int CompareTo(FormID value)
        {
            return CompareTo((uint)value);
        }

        public override bool Equals(object obj)
        {
            uint value = 0;

            if (obj is FormID)
                value = (uint)((FormID)obj);
            else if (obj is UInt32)
                value = (uint)obj;
            else
                value = Convert.ToUInt32(obj);

            return Equals(value);
        }

        public bool Equals(uint obj)
        {
            return m_value == obj;
        }

        public override int GetHashCode()
        {
            return m_value.GetHashCode();
        }

        public override string ToString()
        {
            return "0x" + m_value.ToString("X2").PadLeft(8, '0');
        }

        public string ToString(IFormatProvider provider)
        {
            return "0x" + m_value.ToString("X2").PadLeft(8, '0');
        }

        public string ToString(string format)
        {
            return m_value.ToString(format);
        }

        public string ToReverseString()
        {
            byte[] bytes = BitConverter.GetBytes(m_value);
            string retval = "";
            foreach (byte b in bytes)
                retval += b.ToString("X2");
            return retval;
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return m_value.ToString(format, provider);
        }

        public static uint Parse(string s)
        {
            return uint.Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }

        public static uint Parse(string s, NumberStyles style)
        {
            return uint.Parse(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static uint Parse(string s, IFormatProvider provider)
        {
            return uint.Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }

        public static uint Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return uint.Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        public static bool TryParse(string s, out uint result)
        {
            return uint.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result)
        {
            return uint.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt32;
        }
    }
}
