using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[ExecuteAlways]
[RequireComponent(typeof(TextMeshPro))]
public class coordinate_labeler : MonoBehaviour
{   
    [SerializeField] Color defaultcolor = Color.white;
    [SerializeField] Color blockedcolor = Color.grey;
      [SerializeField] Color exploredcolor = Color.yellow;
    [SerializeField] Color pathcolor = new Color(1f,0.5f,0f);
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();
    gridManager gridManager;
    void Awake() 
    {   
        gridManager = FindObjectOfType<gridManager>();
        label = GetComponent<TextMeshPro>();
        label.enabled = true;
        
        DisplayCoordinates();
    }
    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        } 
        setlabelcolor();
        togglelabels();
    }
    //debug editor 
    void togglelabels()
    {   
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            label.enabled = !label.IsActive();
        }
        
        
    }
    void setlabelcolor()
    {   
        if (gridManager == null) {return;}

        node node = gridManager.getnode(coordinates);

        if (node == null) {return;}

        if (!node.isWalkable)
        {
            label.color = blockedcolor;
        }
        else if (node.isPath)
        {
            label.color = pathcolor;
        }
        else if (node.isExplored)
        {
            label.color = exploredcolor;
        }
        else
        {
            label.color = defaultcolor;
        }

        
    }
    void DisplayCoordinates()
    {   
        // coordinates is a 2D vector, so Y in coordinates is equal to parents Z transform
        
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        label.text = coordinates.x + "," + coordinates.y;
        
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
    
}
