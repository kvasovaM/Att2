using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graph11
{
    public static class DrawUtils
    {
        public static Pen PenLine = new Pen(Color.DarkViolet);
        public static Pen PenNode = new Pen(Color.DarkViolet);
        public static Pen CrimsonPenNode = new Pen(Color.Crimson);
        public static SolidBrush BrushBackground = new SolidBrush(Color.LightSkyBlue);
        public static SolidBrush BrushBackHighLight = new SolidBrush(Color.LemonChiffon);
        public static SolidBrush BrushNodeData = new SolidBrush(Color.Black);
        public static Font FontNode = new Font("Arial", 15);
        public static Font FontEdge = new Font("Arial", 12);
    }
}
