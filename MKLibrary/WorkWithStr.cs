using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKLibrary
{
    class WorkWithStr
    {
        public string Str {get; private set; }
        public WorkWithStr(string str)
        {
            Str = str;
        }

        public string WordN(string S, int k)
        {
            char[] separator = { ' ', '\n' };
            string[] arr = S.Split (separator, StringSplitOptions.RemoveEmptyEntries);
            return arr[k - 1];
        }
    }
}
