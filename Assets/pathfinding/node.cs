using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//pure c# class no monobehavior
[System.Serializable]
public class node
{
    public Vector2Int coordinates;
    public bool isWalkable;
    public bool isExplored;
    public bool isPath;
    public node connectedTo;

    public node(Vector2Int coordinates, bool isWalkable)
    {
        this.coordinates = coordinates;
        this.isWalkable = isWalkable;
    }

    
}
