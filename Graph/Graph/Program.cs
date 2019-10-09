using System;

namespace LABA_8
{
    class Program
    {
        const int n = 10;
        static void Main(string[] args)
        {
            int i, j, start;
            bool[] visited = new bool[n];
            byte[,] graph = {
               //0 1 2 3 4 5 6 7 8 9 10
                {0,0,0,0,0,0,0,0,0,1,0}, // 0
                {0,0,0,0,1,0,0,0,1,0,0}, // 1
                {0,0,0,0,0,0,1,0,0,0,1}, // 2
                {0,0,0,0,0,0,1,0,0,1,0}, // 3
                {0,1,0,0,0,0,0,1,0,0,0}, // 4
                {0,0,0,0,0,0,0,1,0,1,0}, // 5
                {0,0,1,1,0,0,0,0,0,0,0}, // 6
                {0,0,0,0,1,1,0,0,0,0,0}, // 7
                {0,1,0,0,0,0,0,0,0,1,1}, // 8
                {1,0,0,1,0,1,0,0,1,0,0}, // 9
                {0,0,1,0,0,0,0,0,1,0,0} // 10 
            };
            Console.Write("Матрица смежности: \n");
            for (i = 0; i < n; i++)
            {
                visited[i] = false;
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", graph[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Стартовая вершина: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Результат обхода: ");
            DFS(start, visited, graph);
            Console.ReadLine();
        }
        public static void DFS(int st, bool[] visited, byte[,] graph)
        {
            Console.Write("{0}  ", st);
            visited[st] = true;
            for (int r = 0; r < n; r++)
            {
                if (graph[st, r] != 0 && !visited[r])
                {
                    DFS(r, visited, graph);
                }
            }
        }
    }
}
