using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
[RequireComponent(typeof(TextMeshPro))]

public class coordinate_labeler : MonoBehaviour

{
    
    [SerializeField] Color defaultColor = Color.white;
    [SerializeField] Color blockedColor = Color.gray;
    [SerializeField] Color exploredColor = Color.yellow;
    [SerializeField] Color pathColor = new Color(1f, 0.5f, 0f);

    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();
    gridManager gridManager;

    void Awake() {
        gridManager = FindObjectOfType<gridManager>();
        label = GetComponent<TextMeshPro>();
        label.enabled = false;

        DisplayCoordinates();
    }

    void Update()
    {
       if(!Application.isPlaying)
       {
           DisplayCoordinates();
           UpdateObjectName();
           label.enabled = true;
       }

       SetLabelColor();
       ToggleLabels();
    }

    void ToggleLabels()
    {   
        #if UNITY_EDITOR
        if(Input.GetKeyDown(KeyCode.C))
        {
            label.enabled = !label.IsActive();
        }
        #endif
        
    }

    void SetLabelColor()
    {   
        
            
        
        if(gridManager == null) { return; }

        node node = gridManager.getnode(coordinates);

        if(node == null) { return; }

        if(!node.isWalkable)
        {
            label.color = blockedColor;
        }
        else if(node.isPath)
        {
            label.color = pathColor;
        }
        else if(node.isExplored)
        {
            label.color = exploredColor;
        }
        else
        {
            label.color = defaultColor;
        }
    }

    void DisplayCoordinates() 
    {   
        // note to self leave directives alone
        #if UNITY_EDITOR
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        #endif   
        label.text = coordinates.x + "," + coordinates.y;
    }

    void UpdateObjectName()
    {   
        
        transform.parent.name = coordinates.ToString();
       
    }
    
}

