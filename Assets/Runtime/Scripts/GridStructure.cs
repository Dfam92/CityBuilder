using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStructure
{
    private int cellSize;

    public GridStructure(int cellSize)
    {
        this.cellSize = cellSize;
    }

    public Vector3 CalculateGridPos(Vector3 inputPos)
    {
        //int x = Mathf.FloorToInt((float)inputPos.x / cellSize);
        //int z = Mathf.FloorToInt((float)inputPos.z / cellSize);
        //return new Vector3(x * cellSize, 0, z * cellSize);
        return new Vector3(1, 1, 1);
    }
}
