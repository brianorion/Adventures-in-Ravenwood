using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public (int, int) position;
    public Cell(int x, int y)
    {
        position = (x, y);
    }

}
