using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManager : MonoBehaviour
{   
    [SerializeField] Vector2Int gridsize;
    // Start is called before the first frame update
    
    Dictionary<Vector2Int, node> grid = new Dictionary<Vector2Int, node>();
    public Dictionary<Vector2Int, node> Grid {get {return grid;} }
    void Awake() 
    {
        creategrid();
    }
    public node getnode(Vector2Int coordinates)
    {   
        if (grid.ContainsKey(coordinates))
        {
            return grid[coordinates];
        }
        return null;
    }
    void creategrid()
    {
        for (int x = 0; x < gridsize.x; x++)
        {
            for (int y = 0; y < gridsize.y; y++)
            {
                Vector2Int coordinates = new Vector2Int(x,y);
                grid.Add(coordinates, new node(coordinates, true));
                
            }
        }

    }
}
