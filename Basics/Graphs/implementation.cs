    //adjacency list implementation
    class Program
    {
        void AddEdge(List<int>[] adj, int u, int v)
        {
            adj[u].Add(v);
            adj[v].Add(u);

        }

        void PrintGraph(List<int>[]adj)
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine($"Adjacency list of vertex {i} :");
                foreach (var item in adj[i])
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            List<int>[] adj = new List<int>[5];

            adj[0] = new List<int>();
            adj[1] = new List<int>();
            adj[2] = new List<int>();
            adj[3] = new List<int>();
            adj[4] = new List<int>();

            obj.AddEdge(adj, 0, 1);
            obj.AddEdge(adj, 0, 4);
            obj.AddEdge(adj, 1, 2);
            obj.AddEdge(adj, 1, 3);
            obj.AddEdge(adj, 1, 4);
            obj.AddEdge(adj, 2, 3);
            obj.AddEdge(adj, 3, 4);

            obj.PrintGraph(adj);

            Console.ReadLine();
        }
    } 