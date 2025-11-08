## BFS
### 2D Array:

Problem: “Shortest Path in a Binary Matrix” (Easy version)
Problem statement:

You are given a 2D grid of size n x m filled with:

0 → free cell (you can move here)

1 → blocked cell (you cannot move here)

You start at the top-left corner (0, 0) and want to reach the bottom-right corner (n-1, m-1).

You can move up, down, left, right (4 directions).

Find the minimum number of steps required to reach the destination.
If it’s not possible, return -1.

## Example:
Input:
grid = [
  [0, 1, 0],
  [0, 0, 0],
  [1, 0, 0]
]

Output: 4

Explanation:

Possible path:

(0,0) → (1,0) → (1,1) → (1,2) → (2,2)