using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MKLibrary;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TrianglesTest()
        {
            
            List<Triangle> triangles = new List<Triangle>()
            {
                new Triangle(new Point(0,0), new Point(0,2), new Point(2,0)),
                new Triangle(new Point(0,0), new Point(0,4), new Point(4,0)),
               
            };

            TriangleUtils utils = new TriangleUtils(triangles);
            List<List<Triangle>> res = utils.GetAnswer();

            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void TrianglesTest2()
        {

            List<Triangle> triangles = new List<Triangle>()
            {
                new Triangle(new Point(0,0), new Point(0,2), new Point(2,0)),
                new Triangle(new Point(0,0), new Point(0,4), new Point(4,0)),

                new Triangle(new Point(5,0), new Point(5,3), new Point(8,0)),
                new Triangle(new Point(5,0), new Point(5,9), new Point(14,0)),

            };

            TriangleUtils utils = new TriangleUtils(triangles);
            List<List<Triangle>> res = utils.GetAnswer();

            Assert.AreEqual(2, res.Count);
        }
        [TestMethod]
        public void TrianglesTest3()
        {

            List<Triangle> triangles = new List<Triangle>()
            {
                new Triangle(new Point(0,0), new Point(0,2), new Point(2,0)),
                new Triangle(new Point(0,0), new Point(0,4), new Point(4,0)),

                new Triangle(new Point(5,0), new Point(5,3), new Point(8,0)),
                new Triangle(new Point(5,0), new Point(5,9), new Point(14,0)),

                new Triangle(new Point(5,0), new Point(5,3), new Point(8,0)),
                new Triangle(new Point(5,0), new Point(5,10), new Point(15,0)),

            };

            TriangleUtils utils = new TriangleUtils(triangles);
            List<List<Triangle>> res = utils.GetAnswer();

            Assert.AreEqual(2, res.Count);
        }
    }
}
