using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKLibrary
{
    public class TriangleUtils
    {
        public List<Triangle> Triangles { get; set; }


        public TriangleUtils(List<Triangle> triangles)
        {
            Triangles = triangles;
        }

        public List<List<Triangle>> GetAnswer()
        {
            List<int> counted = new List<int>();
            List<List<Triangle>> result = new List<List<Triangle>>();

            for (int i = 0; i < Triangles.Count; i++)
            {
                List<Triangle> tmp = new List<Triangle>();
                if (!counted.Contains(i))
                {
                    tmp.Add(Triangles[i]);
                    counted.Add(i);
                }



                for (int j = i; j < Triangles.Count; j++)
                {
                    if (Triangles[i].AreSimilar(Triangles[j]) && !counted.Contains(j))
                    {
                        tmp.Add(Triangles[j]);
                        counted.Add(j);
                    }
                }
                if (tmp.Count != 0)
                {
                    result.Add(tmp);
                }
            }

            return result;
        }

    }
}
