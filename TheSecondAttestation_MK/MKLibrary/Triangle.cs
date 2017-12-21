using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKLibrary
{
    public class Triangle
    {
        public Point V1 { get; set; }
        public Point V2 { get; set; }
        public Point V3 { get; set; }

        public Triangle(Point v1, Point v2, Point v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public bool AreSimilar(Triangle triangle)
        {
            double k1 = Length(V1, V2)  / Length(triangle.V1, triangle.V2);
            double k2 = Length(V2, V3) / Length(triangle.V2, triangle.V3);
            double k3 = Length(V1, V3) / Length(triangle.V1, triangle.V3);

            return (k1 == k2) && (k2 == k3) && (k1 == k3);
        }

        private double Length(Point v1, Point v2)
        {
            return Math.Sqrt(Math.Pow(v1.X - v2.X, 2) + Math.Pow(v1.Y - v2.Y, 2));
        }
    }
}
