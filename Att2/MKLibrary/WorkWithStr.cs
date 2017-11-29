using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKLibrary
{
    public class WorkWithStr
    {
        public string Str {get; set; }

        public WorkWithStr(string str)
        {
            Str = str;
        }

        public string WordN(int k)
        {
            char[] separator = { ' ' };
            string[] arr = Str.Split (separator, StringSplitOptions.RemoveEmptyEntries);

            return (k >= 0 && k <= arr.Length) ? arr[k - 1] : "" ;
        }

        public string WordNCustom(int k)
        {
            char[] separator = { ' ' };
            int currentK = 0;
            int begin = -1;

            for (int i=1; i < Str.Length; i++)
            {
                if ((Str[i] == ' ' && Str[i-1] != ' ') || i == Str.Length - 1)
                {
                    currentK++;

                    if (currentK == k)
                    {
                        string word = "";
                        int end = (i == Str.Length - 1) ? i : i - 1;
                        for (int j = begin; j <= end; j++)
                        {
                            word += Str[j];
                        }

                        return word;
                    }
                }

            }

            return "";
        }
    }
}
