using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Task7246
    {
  
        public int startIndex { get; set; }
        public int elementsCount { get; set; }

        public Task7246(int[] A)
        {
            int start = 0;
            int len = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] < A[i + 1])
                {
                }
            }

            // * * *
            startIndex = start;
            elementsCount = len;
        }

    }
}
