using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Graph11
{
    public class Graph
    {
        private List<Node> NodesList = new List<Node>();
        private List<Edge> EdgesList = new List<Edge>();

        public int GetNodesListCount()
        {
            return NodesList.Count;
        }

        public void AddNode(int x, int y, string name)
        {
            if (FindByXY(x, y) == null)
            {
                Node node = new Node();
                node.x0 = x;
                node.y0 = y;
                node.Name = name;
                node.Edges = new List<Edge>();
                NodesList.Add(node);
            }
        }

        private void ClearIsConnected()
        {
            for (int i = 0; i < NodesList.Count; i++)
            {
                NodesList[i].ConnectedInt = 0;
            }//чистит визиты для проверки 
        }

        private bool CheckConnected()
        {
            //флаг = false означает что не найдено узла примыкающего к визитному с нулевым индексом
            //флаг = true значит найден примыкающий к визитному узлу сосед с нулевым визитом
            //Н = 1 это присвоено нулевому узлу
            
            ClearIsConnected();
            bool flag = false;
            int N = 1;
            NodesList[0].ConnectedInt = N;

            while (true)
            {
                for (int i = 0; i < NodesList.Count; i++)//цикл по всем узлам
                {
                    if (NodesList[i].ConnectedInt == N)//если визит == N у Итого узла
                    {
                        for (int j = 0; j < NodesList[i].Edges.Count; j++)//присвоить соседям с нулевым визитом N+1 и флаг сделать = 1
                        {
                            if (NodesList[i].Edges[j].LeftNode.ConnectedInt == N && NodesList[i].Edges[j].RightNode.ConnectedInt==0)
                            {
                                NodesList[i].Edges[j].RightNode.ConnectedInt = N + 1;
                                flag = true;
                            }
                            if(NodesList[i].Edges[j].LeftNode.ConnectedInt == 0 && NodesList[i].Edges[j].RightNode.ConnectedInt == N)
                            {
                                NodesList[i].Edges[j].LeftNode.ConnectedInt = N + 1;
                                flag = true;
                            }
                        }
                    }
                }
                // проверка остались ли узлы с нулевым визитом
                bool AreThereNoZeroNodes = true; // бул нулевыхУзловНет = тру

                for (int k = 0; k < NodesList.Count; k++)//цикл* по всем нодам 
                {
                    if (NodesList[k].ConnectedInt == 0)//проверка если визит узла == 0
                    {
                        AreThereNoZeroNodes = false;// нулевыхУзловНет = фолс
                        break;//брейк цикл*
                    }
                }

                if (AreThereNoZeroNodes)
                {
                    return true;//если нулевых узлов нет ретурн что граф связный (проверям флаг нулевыхУзловНет==тру)
                }

                if (AreThereNoZeroNodes == false && flag == false)
                {
                    return false;//если нулевыхУзловНет == фолс && флаг == 0 то граф не связный ретурн фолс
                }
                else
                {//елсе Н++ и флаг = 0
                    N++;
                    flag = false;
                }
            }
        }

        private void ClearRoutes()
        {
            foreach (Node node in NodesList)
            {
                if (node != null)
                {
                    node.RouteLength = 0;
                }
            }
        }

        private void ClearVisits()
        {
            for (int g = 0; g < NodesList.Count; g++)
            {
                NodesList[g].IsVisited = false;
            }
        }

        private void ClearDists()
        {
            for (int q = 0; q < NodesList.Count; q++)
            {
                NodesList[q].dist = Int32.MaxValue;
                NodesList[q].oldDist = Int32.MaxValue;
            }
        }

        private bool AreThereBadDists()
        {
            for (int i = 0; i < NodesList.Count; i++)
            {
                if (NodesList[i].dist != NodesList[i].oldDist || NodesList[i].dist == Int32.MaxValue ||
                    NodesList[i].oldDist == Int32.MaxValue)
                {
                    return true;
                }
            }

            return false;
        }

        private void DijkstMakeDistances(Node target)
        {
            target.oldDist = 0;
            target.dist = 0;
            Node tempo = new Node();
            while (AreThereBadDists())
            {
                for (int r = 0; r < NodesList.Count; r++)
                {
                    for (int h = 0; h < NodesList[r].Edges.Count; h++)
                    {
                        if (NodesList[r] == NodesList[r].Edges[h].RightNode)
                        {
                            tempo = NodesList[r].Edges[h].LeftNode;
                        }
                        else
                        {
                            tempo = NodesList[r].Edges[h].RightNode;
                        }

                        if (tempo.dist != Int32.MaxValue)
                        {

                            if (tempo.dist + NodesList[r].Edges[h].Weight <= NodesList[r].dist)
                            {
                                NodesList[r].oldDist = NodesList[r].dist;
                                NodesList[r].dist = tempo.dist + NodesList[r].Edges[h].Weight;
                            }
                        }
                    }
                }
            }
        }

        public string FindMinSumOfDists()
        {
            if (CheckConnected()==false)
            {
                throw new MyException("Граф не связный!");
            }
            ClearRoutes();
            Node res = new Node();
            res.RouteLength = Int32.MaxValue;

            for (int i = 0; i < NodesList.Count; i++)
            {
                ClearDists();
                ClearVisits();
                DijkstMakeDistances(NodesList[i]);

                for (int s = 0; s < NodesList.Count; s++)
                {
                    NodesList[i].RouteLength += NodesList[s].dist;
                }
            }

            for (int t = 0; t < NodesList.Count; t++)
            {
                if ((NodesList[t].RouteLength <= res.RouteLength))
                {
                    res = NodesList[t];
                }
            }
            return "Город: " + res.Name + " " + "Сумма: " + res.RouteLength.ToString();

        }


        private Node NodeForMove;

        public void MoveNode(int x, int y)
        {
            if (NodeForMove == null)
            {
                NodeForMove = FindByXY(x, y);
                return;
            }
            else
            {
                NodeForMove.x0 = x;
                NodeForMove.y0 = y;
                NodeForMove = null;
            }
        }

        private Edge EdgeGraphAdd;
        public void AddEdge(int x, int y, int weight)
        {
            if (EdgeGraphAdd == null)
            {
                EdgeGraphAdd = new Edge();
                EdgeGraphAdd.LeftNode = FindByXY(x, y);
                if (EdgeGraphAdd.LeftNode != null)
                {
                    FindByXY(x, y).Edges.Add(EdgeGraphAdd);
                }
                return;
            }
            else
            {
                EdgeGraphAdd.RightNode = FindByXY(x, y);
                if (EdgeGraphAdd.RightNode != null)
                {
                    FindByXY(x, y).Edges.Add(EdgeGraphAdd);
                    EdgeGraphAdd.Weight = weight;
                    EdgesList.Add(EdgeGraphAdd);
                    EdgeGraphAdd = null;
                }
            }


        }

        public void DeleteEdge(int x, int y) 
        {
            double dist1, dist2, rebro;
            for (int i = 0; i < EdgesList.Count; i++)
            {
                if (EdgesList[i] != null && EdgesList[i].LeftNode != null && EdgesList[i].RightNode != null)
                {
                    dist1 = Math.Sqrt(Math.Pow(x - EdgesList[i].LeftNode.x0, 2) +
                                      Math.Pow(y - EdgesList[i].LeftNode.y0, 2));
                    dist2 = Math.Sqrt(Math.Pow(x - EdgesList[i].RightNode.x0, 2) +
                                      Math.Pow(y - EdgesList[i].RightNode.y0, 2));
                    rebro = Math.Sqrt(Math.Pow(EdgesList[i].LeftNode.x0 - EdgesList[i].RightNode.x0, 2) +
                                      Math.Pow(EdgesList[i].LeftNode.y0 - EdgesList[i].RightNode.y0, 2));
                    if (Math.Abs(dist1 + dist2 - rebro) < 0.1)
                    {
                        for (int k = 0; k < EdgesList[i].LeftNode.Edges.Count; k++)
                        {
                            if (EdgesList[i] == EdgesList[i].LeftNode.Edges[k])
                            {
                                EdgesList[i].LeftNode.Edges[k] = null;
                                EdgesList[i].LeftNode.Edges.RemoveAt(k);
                                k--;
                            }
                        }
                        for (int u = 0; u < EdgesList[i].RightNode.Edges.Count; u++)
                        {
                            if (EdgesList[i] == EdgesList[i].RightNode.Edges[u])
                            {
                                EdgesList[i].RightNode.Edges[u] = null;
                                EdgesList[i].RightNode.Edges.RemoveAt(u);
                                u--;
                            }
                        }

                        EdgesList[i] = null;
                        EdgesList.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Node x in NodesList)
            {
                if (x != null)
                {
                    x.IsDrawn = false;
                }
            }
            foreach (Node x in NodesList)
            {
                if (x != null)
                {
                    Draw(g, x); 
                }
            }
        }

        private void Draw(Graphics g, Node p)
        {
            if (p.IsDrawn) return;
            if (p.Edges != null)
            {
                foreach (Edge e in p.Edges)
                {
                    if (e != null)
                    {
                        if (p == e.RightNode)
                        {
                            if (e.LeftNode != null)
                            {
                                if (!e.LeftNode.IsDrawn)
                                    DrawEdge(g, p, e.LeftNode, e.Weight); 
                            }
                        }

                        if (p == e.LeftNode)
                        {
                            if (e.RightNode != null)
                            {
                                if (!e.RightNode.IsDrawn)
                                    DrawEdge(g, p, e.RightNode, e.Weight);
                            }
                        }
                    }
                }
            }

            DrawNode(g, p);
            p.IsDrawn = true;
        }

        private void DrawEdge(Graphics g, Node p, Node n, int weight)
        {
            g.DrawLine(DrawUtils.PenLine, p.x0, p.y0, n.x0, n.y0);
            g.DrawString(weight.ToString(), DrawUtils.FontEdge, DrawUtils.BrushNodeData, (p.x0 + n.x0) / 2, (p.y0 + n.y0) / 2);
        }

        private void DrawNode(Graphics g, Node p)
        {
            if (p == NodeForMove)
            {
                g.FillEllipse(DrawUtils.BrushBackHighLight, p.x0 - 20, p.y0 - 20, 40, 40);
                g.DrawEllipse(DrawUtils.CrimsonPenNode, p.x0 - 20, p.y0 - 20, 40, 40);
            }
            else
            {
                g.FillEllipse(DrawUtils.BrushBackground, p.x0 - 20, p.y0 - 20, 40, 40);
                g.DrawEllipse(DrawUtils.PenNode, p.x0 - 20, p.y0 - 20, 40, 40);
            }

            g.DrawString(p.Name, DrawUtils.FontNode, DrawUtils.BrushNodeData, p.x0 - 12, p.y0 - 12);
        }

        private Node FindByXY(int x, int y) 
        {
            foreach (Node p in NodesList)
            {
                if (p != null)
                {
                    if ((p.x0 - x) * (p.x0 - x) + (p.y0 - y) * (p.y0 - y) < 40 * 40) //r - радиус нода
                        return p;
                }
            }
            return null;
        }

        public void DeleteNode(int x, int y)
        {
            if (FindByXY(x, y) != null)
            {
                for (int q = 0; q < NodesList.Count; q++)
                {
                    for (int j = 0; j < NodesList[q].Edges.Count; j++)
                    {
                        if (NodesList[q].Edges[j].RightNode == FindByXY(x, y) || NodesList[q].Edges[j].LeftNode == FindByXY(x, y))
                        {
                            NodesList[q].Edges[j] = null;
                            NodesList[q].Edges.RemoveAt(j);
                            j--;
                        }
                    }
                }

                if (FindByXY(x, y).Edges != null)
                {
                    for (int i = 0; i < FindByXY(x, y).Edges.Count; i++)
                    {
                        FindByXY(x, y).Edges[i] = null;
                        FindByXY(x, y).Edges.RemoveAt(i);
                        i--;
                    }
                }

                for (int k = 0; k < NodesList.Count; k++)
                {
                    if (NodesList[k] == FindByXY(x, y))
                    {
                        NodesList[k] = null;
                        NodesList.RemoveAt(k);
                        k--;
                        break;
                    }
                }
            }

            for (int q = 0; q < NodesList.Count; q++)
            {
                for (int j = 0; j < NodesList[q].Edges.Count; j++)
                {
                    if (NodesList[q].Edges[j].RightNode == null || NodesList[q].Edges[j].LeftNode == null)
                    {
                        NodesList[q].Edges[j] = null;
                        NodesList[q].Edges.RemoveAt(j);
                        j--;
                    }
                }
            }

            for (int n = 0; n < EdgesList.Count; n++)
            {
                if (EdgesList[n].RightNode == null || EdgesList[n].LeftNode == null)
                {
                    EdgesList[n] = null;
                    EdgesList.RemoveAt(n);
                    n--;
                }
            }

        }

        public void SaveGraph(string saveFileName)
        {
            StreamWriter writer = new StreamWriter(saveFileName, true, Encoding.Default);
            for (int i = 0; i < NodesList.Count; i++)
            {
                writer.WriteLine(NodesList[i].Name);
                writer.WriteLine(NodesList[i].x0);
                writer.WriteLine(NodesList[i].y0);
                writer.WriteLine(NodesList[i].dist);
                writer.WriteLine(NodesList[i].oldDist);
                writer.WriteLine(NodesList[i].RouteLength);
            }
            writer.WriteLine("NODESOVER");
            for (int i = 0; i < EdgesList.Count; i++)
            {
                writer.WriteLine(EdgesList[i].Weight);
                writer.WriteLine(EdgesList[i].RightNode.x0);
                writer.WriteLine(EdgesList[i].RightNode.y0);
                writer.WriteLine(EdgesList[i].LeftNode.x0);
                writer.WriteLine(EdgesList[i].LeftNode.y0);
            }
            writer.WriteLine("EDGESOVER");
            writer.Close();
        }

        public Graph LoadGraph(string loadFileName)
        {
            Graph graphRGraph = new Graph();
            StreamReader reader = new StreamReader(loadFileName, Encoding.Default);
            string line = String.Empty;
            while ((line = reader.ReadLine()) != "NODESOVER")
            {
                Node node = new Node();
                node.Edges = new List<Edge>();
                node.Name = line;
                node.x0 = Convert.ToInt32(reader.ReadLine());
                node.y0 = Convert.ToInt32(reader.ReadLine());
                node.dist = Convert.ToInt32(reader.ReadLine());
                node.oldDist = Convert.ToInt32(reader.ReadLine());
                node.RouteLength = Convert.ToInt32(reader.ReadLine());
                graphRGraph.NodesList.Add(node);
            }

            while ((line = reader.ReadLine()) != "EDGESOVER")
            {
                Edge edge = new Edge();
                edge.Weight = Convert.ToInt32(line);
                int xTemp = Convert.ToInt32(reader.ReadLine());
                int yTemp = Convert.ToInt32(reader.ReadLine());
                Node tmp = new Node();
                tmp = graphRGraph.FindByXY(xTemp, yTemp);
                edge.RightNode = tmp;
                tmp.Edges.Add(edge);

                xTemp = Convert.ToInt32(reader.ReadLine());
                yTemp = Convert.ToInt32(reader.ReadLine());
                tmp = graphRGraph.FindByXY(xTemp, yTemp);
                edge.LeftNode = tmp;
                tmp.Edges.Add(edge);

                graphRGraph.EdgesList.Add(edge);
            }
            reader.Close();
            return graphRGraph;
        }
    }
}
