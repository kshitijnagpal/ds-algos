    //adjacency list implementation
    class Program
    {
        public class Graph
        {
            public int vertex;
            public List<int>[] adjList;

            public Graph(int vertex)
            {
                this.vertex = vertex;
                adjList = new List<int>[vertex];

                //init
                for (int i = 0; i < vertex; i++)
                {
                    adjList[i] = new List<int>();
                }
            }
        }

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
            Graph graph = new Graph(5);
            

            obj.AddEdge(graph.adjList, 0, 1);
            obj.AddEdge(graph.adjList, 0, 4);
            obj.AddEdge(graph.adjList, 1, 2);
            obj.AddEdge(graph.adjList, 1, 3);
            obj.AddEdge(graph.adjList, 1, 4);
            obj.AddEdge(graph.adjList, 2, 3);
            obj.AddEdge(graph.adjList, 3, 4);

            obj.PrintGraph(graph.adjList);

            Console.ReadLine();
        }
    } 