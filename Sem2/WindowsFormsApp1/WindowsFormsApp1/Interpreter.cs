using System;

namespace WindowsFormsApp1
{
    public enum Operation
    {
        PLUS = 1,
        MINUS = 2,
        MULTIPLY = 3
    }

    public abstract class Node
    {
        public abstract int DoOperation();

        public int Value
        {
            get { return DoOperation(); }
        }
    }

    public class NodeConst : Node
    {
        int value;

        public NodeConst(int value)
        {
            this.value = value;
        }

        public override int DoOperation()
        {
            return value;
        }
    }

    public class NodeOperation : Node
    {
        public Operation typeOperation;
        public Node left;
        public Node right;

        public NodeOperation(Operation typeOperation, Node left, Node right)
        {
            this.typeOperation = typeOperation;
            this.left = left;
            this.right = right;
        }

        public override int DoOperation()
        {
            int a = Convert.ToInt32(left.Value);
            int b = Convert.ToInt32(right.Value);

            switch (typeOperation)
            {
                case Operation.PLUS:
                    return a + b;
                case Operation.MINUS:
                    return a - b;
                case Operation.MULTIPLY:
                    return a * b;
                default:
                    return 0;
            }
        }
    }

    public class Interpr
    {
        private Node top;

        public int Interpret(string line)
        {
            int value = 0;
            top = null;

            string newline = "";
            foreach (char ch in line)
            {
                if (ch != ' ') newline += ch;
            }

            Expression(ref newline, out top);
            value = top.Value;

            return value;
        }

        bool Test(char ch, params char[] nums)
        {
            return Array.IndexOf(nums, ch) >= 0;
        }

        string Pop(ref string s, byte n)
        {
            string result = s.Substring(0, n);
            s = s.Substring(n);
            return result;
        }

        NodeConst SetConst(ref string s)
        {
            string st = "";
            while ((s != "") && Test(s[0], '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'))
            {
                st += Pop(ref s, 1);
            }
            int k = Convert.ToInt32(st);
            return new NodeConst(k);
        }

        void Expression(ref string s, out Node node)
        {
            node = Term(ref s);

            while ((s.Length > 0) && ((s[0] == '+') | (s[0] == '-')))
            {
                string sign = Pop(ref s, 1);
                Node node2;
                node2 = Term(ref s);
                Node node1 = node;

                Operation t = Operation.PLUS;
                switch (sign[0])
                {
                    case '+':
                        t = Operation.PLUS; break;
                    case '-':
                        t = Operation.MINUS; break;
                }
                node = new NodeOperation(t, node1, node2);
            }
        }

        Node Term(ref string s)
        {
            Node node = null;

            node = SetConst(ref s);
            while ((s.Length != 0) && (s[0] == '*'))
            {
                Pop(ref s, 1);
                Node node2;
                node2 = SetConst(ref s);
                Node node1 = node;

                Operation t = Operation.MULTIPLY;

                node = new NodeOperation(t, node1, node2);
            }
            return node;
        }
    }
}
