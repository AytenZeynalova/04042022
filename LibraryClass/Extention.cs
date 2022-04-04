using System;

namespace LibraryClass
{
    public static  class Extention
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
            {
                return false;
            }
            return true;
        }


        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool HasDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static string  ToCapitalize(this string str)
        {
            return str.ToUpper();
        }

        public static int[] GetValueIndexes(char chr, string str)
        {
            int count = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (chr == str[i])
                {
                    count++;
                    
                }            
            }
            int[] arr = new int[count];
            for (int i = 0; i < str.Length; i++)
            {
                if (chr == str[i])
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        arr[j] = i;
                    }
                }

            }

            return arr;
            
        }
    }
}
