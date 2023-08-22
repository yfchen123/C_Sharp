using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Chapter2
{
    public class Ch02Ex03Numbers
    {
        public void printTable()
        {
            int line_size = 80;
            Console.WriteLine(new string('-', line_size));
            String row1 = String.Format("{0,0}{1,20}{2,20}{3,36}", "Type", "Bytes(s) of memory",
                "Min", "Max");
            Console.WriteLine(row1);
            Console.WriteLine(new string('-', line_size));
            object[] my_types = {new sbyte(), new byte(), new short(), new ushort(),
            new int(), new uint(), new long(), new ulong(), new float(), new double(),
            new decimal()};
            foreach(object my_type in my_types)
            {
                Type this_type = my_type.GetType();
                String min_value = get_min_value(this_type);
                String max_value = get_max_value(this_type);
                String type_print = this_type.ToString().Substring(7).ToLower();
                int first_seperator = 10 - type_print.Length;
                int second_seperator = 45 - first_seperator - type_print.Length;
                int third_seperator = 80 - second_seperator - first_seperator - type_print.Length;
                String row = String.Format("{0,0}{1," + first_seperator + "}" +
                    "{2," + second_seperator + "}{3, " + third_seperator + "}", type_print,
                Marshal.SizeOf(my_type.GetType())
                , min_value
                , max_value);
                Console.WriteLine(row);
            }
            Console.WriteLine(new string('-', line_size));

            
        }
        private String get_min_value(Type this_type)
        {
            if (this_type == typeof(sbyte))
            {
                return sbyte.MinValue.ToString();
            }
            else if (this_type == typeof(byte))
            {
                return byte.MinValue.ToString();
            }
            else if (this_type == typeof(short))
            {
                return short.MinValue.ToString();
            }
            else if (this_type == typeof(ushort))
            {
                return ushort.MinValue.ToString();
            }
            else if (this_type == typeof(int))
            {
                return int.MinValue.ToString();
            }
            else if (this_type == typeof(uint))
            {
                return uint.MinValue.ToString();
            }
            else if (this_type == typeof(long))
            {
                return long.MinValue.ToString();
            }
            else if (this_type == typeof(ulong))
            {
                return ulong.MinValue.ToString();
            }
            else if (this_type == typeof(float))
            {
                return float.MinValue.ToString();
            }
            else if (this_type == typeof(double))
            {
                return double.MinValue.ToString();
            }
            return decimal.MinValue.ToString();
        }

        private String get_max_value(Type this_type)
        {
            if (this_type == typeof(sbyte))
            {
                return sbyte.MaxValue.ToString();
            }
            else if (this_type == typeof(byte))
            {
                return byte.MaxValue.ToString();
            }
            else if (this_type == typeof(short))
            {
                return short.MaxValue.ToString();
            }
            else if (this_type == typeof(ushort))
            {
                return ushort.MaxValue.ToString();
            }
            else if (this_type == typeof(int))
            {
                return int.MaxValue.ToString();
            }
            else if (this_type == typeof(uint))
            {
                return uint.MaxValue.ToString();
            }
            else if (this_type == typeof(long))
            {
                return long.MaxValue.ToString();
            }
            else if (this_type == typeof(ulong))
            {
                return ulong.MaxValue.ToString();
            }
            else if (this_type == typeof(float))
            {
                return float.MaxValue.ToString();
            }
            else if (this_type == typeof(double))
            {
                return double.MaxValue.ToString();
            }
            return decimal.MaxValue.ToString();
        }
    }
}
