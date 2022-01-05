using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class coordinate_labeler : MonoBehaviour
{   
    [SerializeField] Color defaultcolor = Color.white;
    [SerializeField] Color blockedcolor = Color.grey;
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();
    Waypoint waypoint;
    void Awake() 
    {   
        label = GetComponent<TextMeshPro>();
        label.enabled = false;
        waypoint = GetComponentInParent<Waypoint>();
        DisplayCoordinates();
    }
    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        } 
        Colorcoordinates();
        togglelabels();
    }
    void togglelabels()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            label.enabled = !label.IsActive();
        }
    }
    void Colorcoordinates()
    {
        if(waypoint.IsPlaceable)
        {
            label.color = defaultcolor;  
        }
        else
        {
            label.color = blockedcolor;
        }

        
    }
    void DisplayCoordinates()
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        label.text = coordinates.x + "," + coordinates.y;

    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
    
}
