using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph11
{
    public class Node
    {
        public string Name;
        public int RouteLength;
        public List<Edge> Edges;
        public bool IsVisited;
        public int ConnectedInt;
        public bool IsDrawn;
        public int x0, y0;
        public int dist, oldDist; 
    }
}
