// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Linq;

public class Program {

    
    public static void Main(string[] args) {

        //Node root = new Node { 
        //    Value = 4,
        //    Left = new Node
        //    {
        //        Value = 2,
        //        Left = new Node { 
        //            Value = 1
        //        },
        //        Right = new Node
        //        {
        //            Value = 3,
        //        }
        //    },
        //    Right = new Node
        //    {
        //        Value = 6,
        //        Left = new Node
        //        {
        //            Value = 5
        //        },
        //        Right = new Node { 
        //            Value = 7
        //        }
        //    }
        //};

        //Node root = new Node
        //{
        //    Value = 3,
        //    Left = new Node
        //    {
        //        Value = 2,
        //        Left = new Node
        //        {
        //            Value = 1
        //        }
        //    },
        //    Right = new Node
        //    {
        //        Value = 5,
        //        Left = new Node
        //        {
        //            Value = 4
        //        },
        //        Right = new Node
        //        {
        //            Value = 6,
        //            Right = new Node 
        //            { 
        //                Value = 7 
        //            }
        //        }
        //    }
        //};

        Node root = new Node
        {
            Value = 1,
            Left = new Node
            {
                Value = 2,
                Left = new Node
                {
                    Value = 4,
                    Left = new Node
                    {
                        Value = 18
                    },
                    Right = new Node
                    {
                        Value = 19
                    }
                },
                Right = new Node
                {
                    Value = 5
                }
            },
            Right = new Node
            {
                Value = 3,
                Left = new Node
                {
                    Value = 6,
                    Left = new Node
                    {
                        Value = 8,
                        Left = new Node
                        {
                            Value = 9,
                            Left = new Node
                            {
                                Value = 10,
                                Left = new Node
                                {
                                    Value = 11,
                                    Left = new Node
                                    {
                                        Value = 12
                                    },
                                    Right = new Node
                                    {
                                        Value = 13,
                                        Left = new Node
                                        {
                                            Value = 14
                                        },
                                        Right = new Node
                                        {
                                            Value = 15
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                Right = new Node
                {
                    Value = 7,
                    Left = new Node
                    {
                        Value = 16
                    },
                    Right = new Node
                    {
                        Value = 17
                    }
                }
            }
        };

        int res1 = CalcHeight(root);
        Console.WriteLine(res1);

        //Stopwatch sw1 = new Stopwatch();
        //sw1.Start();
        //int res1 = InOrder(root);
        //sw1.Stop();
        //Console.WriteLine("It took: " + sw1.ElapsedMilliseconds);

        //Stopwatch sw2 = new Stopwatch();
        //sw2.Start();
        //int res2 = PreOrder(root);
        //sw2.Stop();
        //Console.WriteLine("It took: " + sw2.ElapsedMilliseconds);

        //Stopwatch sw3 = new Stopwatch();
        //sw3.Start();
        //int res3 = PostOrder(root);
        //sw3.Stop();
        //Console.WriteLine("It took: " + sw3.ElapsedMilliseconds);
        
    }

    public static int CalcHeight(Node root)
    {
        int levels = 0;

        if (root != null)
        {
            int leftHeight = CalcHeight(root.Left);
            int rightHeight = CalcHeight(root.Right);
            levels = Math.Max(leftHeight, rightHeight) + 1;
        }
        else
        {
            levels--;
        }
        return levels;
    }
    public static int InOrder(Node root)
    {
        if (root is not null)
        {
            InOrder(root.Left);
            Console.WriteLine(root.Value);
            InOrder(root.Right);
        }

        return 0;
    }

    public static int PreOrder(Node root)
    {
        if (root is not null)
        {
            Console.WriteLine(root.Value);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        return 0;
    }

    public static int PostOrder(Node root)
    {
        if (root is not null)
        {
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.WriteLine(root.Value);
        }

        return 0;
    }


}

public class Node {
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}





