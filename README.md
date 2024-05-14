# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->
The problem requires us to find the maximum gold that can be collected from a grid where movement is allowed in four directions (up, down, left, right). A Depth-First Search (DFS) approach is suitable here as it allows exploring all possible paths starting from any cell containing gold. By marking cells as visited during the exploration and unmarking them when backtracking, we can ensure that no cell is visited more than once per path.

# Approach
<!-- Describe your approach to solving the problem. -->
1. Initialization:

Initialize a variable maxGold to keep track of the maximum gold collected.
Get the dimensions of the grid (number of rows and columns).

2. DFS Function:

Create a helper function DFS that takes the grid, current coordinates (x, y), and a visited matrix as inputs.
Check boundary conditions and whether the cell has been visited or contains no gold.
Mark the current cell as visited and collect the gold in the current cell.
Recursively call DFS for all four possible directions (up, down, left, right) and compute the gold collected from each path.
Unmark the cell for backtracking purposes and return the maximum gold collected from any path starting from the current cell.

3. Iterate Through the Grid:

Iterate over each cell in the grid.
If the cell contains gold, call the DFS function starting from that cell.
Update maxGold with the maximum value returned by the DFS function.

4. Return Result:

Finally, return the maxGold which contains the maximum amount of gold that can be collected.
# Complexity
- Time complexity:
<!-- Add your time complexity here, e.g. $$O(n)$$ -->
The time complexity is O(m×n×(4^k) ), where m and n are the dimensions of the grid and k is the number of cells containing gold. This is because in the worst case, the DFS explores four possible directions for each cell, and each cell might be visited multiple times due to different paths.

- Space complexity:
<!-- Add your space complexity here, e.g. $$O(n)$$ -->
The space complexity is O(m×n), which is used for the visited matrix and the recursion stack in DFS. In the worst case, the depth of the recursion stack can be equal to the number of cells in the grid, resulting in a space complexity proportional to the grid size.
