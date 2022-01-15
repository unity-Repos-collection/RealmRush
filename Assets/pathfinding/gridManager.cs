using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManager : MonoBehaviour
{   
    [SerializeField] Vector2Int gridsize;
    // Start is called before the first frame update
    
    Dictionary<Vector2Int, node> grid = new Dictionary<Vector2Int, node>();
    void Awake() 
    {
        creategrid();
    }
    void creategrid()
    {
        for (int x = 0; x < gridsize.x; x++)
        {
            for (int y = 0; y < gridsize.y; y++)
            {
                Vector2Int coordinates = new Vector2Int(x,y);
                grid.Add(coordinates, new node(coordinates, true));
                Debug.Log(grid[coordinates].coordinates + " = " + grid[coordinates].isWalkable);  
            }
        }

    }
}
