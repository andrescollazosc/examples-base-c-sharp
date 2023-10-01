using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args) {
        Node root = new Node
        {
            Value = 1,
            Left = new Node
            {
                Value = 2,
                Right = new Node
                {
                    Value = 4,
                }
            },
            Right = new Node
            {
                Value = 3,
                Right = new Node
                {
                    Value = 5
                }
            }
        };

        //Node root = new Node
        //{
        //    Value = 1,
        //    Left = new Node
        //    {
        //        Value = 3,
        //        Right = new Node
        //        {
        //            Value = 5,
        //        }
        //    },
        //    Right = new Node
        //    {
        //        Value = 2,
        //        Right = new Node
        //        {
        //            Value = 4
        //        }
        //    }
        //};

        //Node root = new Node
        //{
        //    Value = 1,
        //    Left = new Node
        //    {
        //        Value = 2,
        //        Left = new Node
        //        { 
        //            Value = 4,
        //            Left = new Node
        //            {
        //                Value = 6,
        //                Right = new Node
        //                {
        //                    Value = 9
        //                }
        //            }
        //        }
        //    },
        //    Right = new Node
        //    {
        //        Value = 3,
        //        Left = new Node
        //        {
        //            Value = 5,
        //            Left = new Node
        //            {
        //                Value = 7,
        //            },
        //            Right = new Node
        //            {
        //                Value = 8,
        //                Left = new Node
        //                {
        //                    Value = 10,
        //                },
        //                Right = new Node
        //                {
        //                    Value = 11
        //                }
        //            }
        //        }
        //    }
        //};

        //Console.WriteLine("Before"); 
        //InOrder(root);

        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine("Nodes: " + n + "\n");

        List<List<int>> indexes = new List<List<int>> {
            //new List<int> { 2, 3 },
            //new List<int> { -1, -1 },
            //new List<int> { -1, -1 }

            //new List<int> { 2, 3 },
            //new List<int> { -1, 4 },
            //new List<int> { -1, 5 },
            //new List<int> { -1, - 1 },
            //new List<int> { -1, - 1 }

            new List<int> { 2, 3 },
            new List<int> { 4, -1 },
            new List<int> { 5, -1 },
            new List<int> { 6, -1 },
            new List<int> { 7, 8 },
            new List<int> { -1, 9 },
            new List<int> { -1, -1 },
            new List<int> { 10, 11 },
            new List<int> { -1, -1 },
            new List<int> { -1, -1 },
            new List<int> { -1, -1 },
        };
        Console.WriteLine("Indexes: " + JsonSerializer.Serialize(indexes) + "\n");


        //List<int> queries = new List<int> { 1, 1 };
        //List<int> queries = new List<int> { 2 };
        List<int> queries = new List<int> { 2, 4 };
        Console.WriteLine("Queries:");
        Console.WriteLine(queries.Count);
        Console.WriteLine(JsonSerializer.Serialize(queries) + "\n");

        var a = swapNodes(indexes, queries);

        //Console.WriteLine("After");
        //InOrder(a);
    }

    public static List<List<int>> swapNodes(List<List<int>> indexes, List<int> queries)
    {
        
        int h = 1;

        //Aquí se recorre la lista completa
        //indexes.ForEach(index =>
        //{
        //    counter++;
        //    if (counter >= 2)
        //    {



        //        //Aquí se cuentan la cantidad de elementos de cada dupla de la lista
        //        if (index.Count == 2)
        //        {
        //            int numero1 = index[0];
        //            int numero2 = index[1];

        //            //Aquí se valida si cada número es natural o no
        //            if (numero1 >= 0 && numero2 >= 0 || numero1 >= 0 && numero2 < 0 || numero1 < 0 && numero2 >= 0)
        //            {
        //                h++;
        //            }
        //        }
        //    }
        //});

        Stack<List<int>> stackIndexes = new Stack<List<int>>(indexes);

        List<List<List<int>>> tree = new List<List<List<int>>>();

        List<List<int>> level1;
        List<List<int>> level2;//,[4,-1],[5,-1]
        List<List<int>> level3 = new List<List<int>>();//[6,-1],[7,8],[-1,9],[-1,-1]...
        int counter = 1;
        for (int i = 0; i <= stackIndexes.Count; i++) {

            if (i==0)
            {
                level1 = new List<List<int>>();
                level1.Add(stackIndexes.Pop());
            }

            for (int j = 0; j < counter; j++) {
                
                new List<List<int>>().Add(stackIndexes.Pop());

            }

            counter = counter * 2;
        }

        //queries.ForEach(k =>
        //{
        //    for (int i = 1; i <= h; i++)
        //    {
        //        if (i % k == 0)
        //        {
        //            Console.WriteLine("Se hizo el intercambio");
        //        }
        //    }
        //});

        Console.WriteLine("Depth");
        Console.WriteLine(JsonSerializer.Serialize(h));

        return null;
    }

    //public static Node swap(Node root)
    //{
    //    Node aux = root.Left;
    //    root.Left = root.Right;
    //    root.Right = aux;

    //    return root;
    //}

    //public static int InOrder(Node root)
    //{
    //    if (root is not null)
    //    {
    //        InOrder(root.Left);
    //        Console.WriteLine(root.Value);
    //        InOrder(root.Right);
    //    }

    //    return 0;
    //}

    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}