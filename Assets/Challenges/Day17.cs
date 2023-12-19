using System;
using System.Collections.Generic;
using UnityEngine;

public class Day17 : MonoBehaviour
{
    string _input = "2413432311323\r\n3215453535623\r\n3255245654254\r\n3446585845452\r\n4546657867536\r\n1438598798454\r\n4457876987766\r\n3637877979653\r\n4654967986887\r\n4564679986453\r\n1224686865563\r\n2546548887735\r\n4322674655533";

    void Awake()
    {
        int[,] grid = StringToGrid(_input);

        Node start = new Node(0, 0);
        Node goal = new Node(grid.GetLength(0), grid.GetLength(1));

        List<Node> path = FindPathWithWeights(grid, start, goal);

        if (path != null)
        {
            Debug.Log("Path found:");
            foreach (var node in path)
            {
                Debug.Log($"({node.X}, {node.Y})");
            }
        }
        else
        {
            Debug.Log("No path found.");
        }
    }

    public static int[,] StringToGrid(string input)
    {
        string[] inputLines = Common.SplitLines(input);

        int[,] grid = new int[inputLines[0].Length, inputLines.Length];

        for (int y = 0; y < grid.GetLength(1); y++)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                grid[x, y] = int.Parse(inputLines[y][x].ToString());
            }
        }

        return grid;
    }

    public class Node : IComparable<Node>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double G { get; set; }
        public double H { get; set; }
        public double F => G + H;
        public Node Parent { get; set; }

        public Node(int x, int y)
        {
            X = x;
            Y = y;
            G = 0;
            H = 0;
            Parent = null;
        }

        public int CompareTo(Node other)
        {
            if (other == null) return 1;
            return F.CompareTo(other.F);
        }
    }

    private static readonly int[,] Directions = { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };

    public static List<Node> FindPathWithWeights(int[,] grid, Node start, Node goal)
    {
        var openSet = new SortedSet<Node>();
        var closedSet = new HashSet<Node>();
        var cameFrom = new Dictionary<Node, Node>();

        start.G = 0;
        start.H = Heuristic(start, goal);
        openSet.Add(start);

        while (openSet.Count > 0)
        {
            var current = openSet.Min;
            openSet.Remove(current);

            if (current.X == goal.X && current.Y == goal.Y)
                return ReconstructPath(cameFrom, current);

            closedSet.Add(current);

            for (int i = 0; i < 4; i++)
            {
                int newX = current.X + Directions[i, 0];
                int newY = current.Y + Directions[i, 1];

                if (newX < 0 || newX >= grid.GetLength(0) || newY < 0 || newY >= grid.GetLength(1))
                    continue;

                if (closedSet.Contains(new Node(newX, newY)))
                    continue;

                var neighbor = new Node(newX, newY);
                double tentativeGScore = current.G + CalculateCost(grid[newX, newY]); // Consider the weighted cost

                if (!openSet.Contains(neighbor) || tentativeGScore < neighbor.G)
                {
                    cameFrom[neighbor] = current;
                    neighbor.G = tentativeGScore;
                    neighbor.H = Heuristic(neighbor, goal);
                    if (!openSet.Contains(neighbor))
                        openSet.Add(neighbor);
                }
            }
        }

        return null;
    }

    private static double Heuristic(Node a, Node b)
    {
        return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)); // Euclidean distance heuristic
    }

    private static List<Node> ReconstructPath(Dictionary<Node, Node> cameFrom, Node current)
    {
        var path = new List<Node> { current };
        while (cameFrom.ContainsKey(current))
        {
            current = cameFrom[current];
            path.Insert(0, current);
        }
        return path;
    }

    private static double CalculateCost(int tileWeight)
    {
        // Adjust as needed based on the weights of the tiles
        // Example: You might apply different costs for different types of terrain
        return tileWeight;
    }

}