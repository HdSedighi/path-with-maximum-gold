public class Solution {
    public int GetMaximumGold(int[][] grid) {
        int maxGold = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        // Helper function to perform DFS
        int DFS(int[][] grid, int x, int y, bool[,] visited) {
            // If out of bounds, cell is zero, or already visited
            if (x < 0 || x >= rows || y < 0 || y >= cols || grid[x][y] == 0 || visited[x, y]) {
                return 0;
            }

            // Mark this cell as visited
            visited[x, y] = true;

            // Amount of gold in the current cell
            int goldCollected = grid[x][y];

            // Explore all four directions
            int up = DFS(grid, x - 1, y, visited);
            int down = DFS(grid, x + 1, y, visited);
            int left = DFS(grid, x, y - 1, visited);
            int right = DFS(grid, x, y + 1, visited);

            // Unmark this cell for backtracking
            visited[x, y] = false;

            // Return the maximum gold collected by taking any path
            return goldCollected + Math.Max(Math.Max(up, down), Math.Max(left, right));
        }

        // Iterate through each cell in the grid
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                // Start DFS from any cell with gold
                if (grid[i][j] > 0) {
                    // Keep track of visited cells
                    bool[,] visited = new bool[rows, cols];
                    // Update the maximum gold collected
                    maxGold = Math.Max(maxGold, DFS(grid, i, j, visited));
                }
            }
        }

        return maxGold;
    }
}
