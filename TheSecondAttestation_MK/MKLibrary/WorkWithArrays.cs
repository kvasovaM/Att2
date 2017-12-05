using System;

namespace MKLibrary
{
    public class WorkWithArrays
    {
        public int[] A { set; get; }

        public WorkWithArrays(int[] array)
        {
            A = array;
        }

        public void SizeAndIndex(out int size, out int index)
        {
            index = -1;
            size = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int counter = 1;

                if (A.Length == 1)
                {
                    size = 1;
                    index = 0;
                }

                for (int j = i; j < A.Length - 1; j++)
                {
                    if (A[j + 1] < A[j])
                    {
                        i = i + counter - 1;
                        break;
                    }
                    else
                    {
                        counter++;
                    }

                    if (counter >= size)
                    {
                        size = counter;
                        index = i;
                    }
                }
            }
        }

        public int IsMix()
        {
            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 1 || A[i] > A.Length || (i > 0 && Array.IndexOf(A, A[i], 0, i) != -1))
                {
                    result = i + 1;
                    break;
                }
            }
            return result;
        }
    }
}