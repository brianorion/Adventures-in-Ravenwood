using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private int boardSize;

    private Cell[,] grid;

    private void Awake()
    {
        grid = new Cell[boardSize, boardSize];
        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                grid[row, col] = new Cell(row, col);
            }
        }
    }
    private void Start()
    {
        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                Debug.Log(grid[row, col].position);
            }
        }
    }
}
