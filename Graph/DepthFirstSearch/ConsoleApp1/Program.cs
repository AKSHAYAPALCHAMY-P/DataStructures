namespace DFS;

public class DepthFirstSearch
{
    public static void Main(string[] args)
    {
        var graph = new[,]
        {
            { 0, 1, 1, 0, 0 },
            { 1, 0, 0, 1, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 0, 0, 1 },
            { 0, 1, 1, 1, 0 }
        };
        var nVertex = graph.GetLength(0);
        var dfs = new DepthFirstSearch();
        var result = dfs.DFS(graph, nVertex);
        Console.WriteLine("DFS Traversal Order:");
        while (result.Count > 0) Console.Write(result.Pop() + " ");
    }

    public Stack<int> DFS(int[,] graph, int nVertex)
    {
        var nStack = new Stack<int>();
        var nvisited = new bool[nVertex];

        nStack.Push(0);
        while (nStack.Count > 0)
        {
            var nCurrentVisisted = nStack.Peek();

            if (!nvisited[nCurrentVisisted])
            {
                nvisited[nCurrentVisisted] = true;
                for (var i = 0; i < nVertex; i++)
                    if (graph[nCurrentVisisted, i] == 1 && !nvisited[i])
                        nStack.Push(i);
            }
        }

        return nStack;
    }
}