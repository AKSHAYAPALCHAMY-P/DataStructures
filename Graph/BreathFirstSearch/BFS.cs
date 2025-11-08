namespace BreathFirstSearch;

public class BFS
{
    public int ShortestPath(int[][] nArray)
    {
        var nRow = nArray.Length;
        var nColumn = nArray[0].Length;

        if (nArray[0][0] == 1 || nArray[nRow - 1][nColumn - 1] == 1)
            return -1;

        var bVisited = new bool[nRow, nColumn];
        var nQueue = new Queue<(int nRows, int nColumns, int nDistance)>();

        nQueue.Enqueue((0, 0, 0));
        bVisited[0, 0] = true;

        var nDirections = new[]
        {
            new[] { 1, 0 }, //down
            new[] { -1, 0 }, //up
            new[] { 0, 1 }, // right
            new[] { 0, -1 } // left
        };

        while (nQueue.Count > 0)
        {
            var (nRows, nColumns, nDistance) = nQueue.Dequeue();
            if (nRows == nRow - 1 && nColumns == nColumns - 1) return nDistance;

            foreach (var dis in nDirections)
            {
                var nRowsForTraverse = nRows + dis[0];
                var nColumnsTraverse = nColumns + dis[1];

                if (nRowsForTraverse > 0 && nColumnsTraverse <nRow &&
                    nColumnsTraverse >= 0 && nColumnsTraverse < nColumn &&
                    nArray[nRowsForTraverse][nColumnsTraverse] == 0 &&
                    !bVisited[nRowsForTraverse, nColumnsTraverse])
                {
                    nQueue.Enqueue((nRowsForTraverse, nColumnsTraverse, nDistance + 1));
                    bVisited[nRowsForTraverse, nColumnsTraverse] = true;
                }
            }
        }

        return -1;
    }
}