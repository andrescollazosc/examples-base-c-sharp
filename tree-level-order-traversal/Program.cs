using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        //Node root = new Node
        //{
        //    Value = 1,
        //    Right = new Node
        //    {
        //        Value = 2,
        //        Right = new Node
        //        {
        //            Value = 5,
        //            Left = new Node
        //            {
        //                Value = 3,
        //                Right = new Node
        //                {
        //                    Value = 4
        //                }
        //            },
        //            Right = new Node
        //            {
        //                Value = 6
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

        //Console.WriteLine(InOrder(root) + "\n");

        Queue<Node> nodes = new Queue<Node>();
        nodes.Enqueue(root);

        while (nodes.Count > 0)
        {
            Node node = nodes.Dequeue();

            if (node.Left != null)
                nodes.Enqueue(node.Left);

            if (node.Right != null)
                nodes.Enqueue(node.Right);

            Console.Write(node.Value+",");
        }

        //Console.Write(JsonSerializer.Serialize(listVisited));
    }
    
}

public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}