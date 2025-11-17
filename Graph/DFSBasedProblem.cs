namespace NumInIslands
{
	public class Islands
	{
		public static void Main(string[] args)
		{
			char[][] grid = new[]
			                {
				                new[] { '1', '1', '1', '1', '0' },
				                new[] { '1', '1', '0', '1', '0' },
				                new[] { '1', '1', '0', '0', '0' },
				                new[] { '0', '0', '0', '0', '0' }
			                };

			Islands isLands = new Islands();
			int nResult = isLands.NumIsLands(grid);

			Console.WriteLine($"Number of Islands:{nResult}");
		}

		public int NumIsLands(char[][] grid)
		{
			if(grid == null || grid.Length == 0) return 0;

			int nRows = grid.Length; //nRows
			int nCols = grid[0].Length; //nCols
			int nCount = 0;

			for(int i = 0; i < nRows; i++)
			{
				for(int j = 0; j < nCols; j++)
				{
					if(grid[i][j] == '1')
					{
						nCount++;
						DFS(grid, i, j, nRows, nCols);
					}
				}
			}

			return nCount;
		}

		public void DFS(char[][] grid, int i, int j, int nRows, int nCols)
		{
			//Boundary check
			if(i < 0 || j < 0 || i >= nRows || j >= nCols)
			{
				return;
			}

			//If water or already visited
			if(grid[i][j] == '0')
				return;

			//Mark visited
			grid[i][j] = '0';

			//Explore 4 directions
			DFS(grid, i + 1, j, nRows, nCols);
			DFS(grid, i - 1, j, nRows, nCols);
			DFS(grid, i, j + 1, nRows, nCols);
			DFS(grid, i, j - 1, nRows, nCols);
		}
	}
}
