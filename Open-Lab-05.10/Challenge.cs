using System;
using System.Linq;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            string numstring =num.ToString();
            char[] chars=numstring.ToCharArray();
            int result = 1;
            int i = -1;
            int j = (int)numstring.Length - 1;
            foreach (char c in chars)
            {
                if (i < j) 
                        {
                            int intchar = (int)Char.GetNumericValue(c);
                            result = result * intchar;
                            i++;
                        }
            }
            return result;

         
        }
    }
}
