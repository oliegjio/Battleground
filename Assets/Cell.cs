using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{

    public bool highlighted;
    private Material selectionMaterial;
    private Material legacyMaterial;


    void Start()
    {
        selectionMaterial = Resources.Load("SelectionCellMaterial") as Material;
        legacyMaterial = Resources.Load("CellMaterial") as Material;
    }

    public void ToggleHightlight()
    {
        if (highlighted)
        {
            DisableHightlight();
        }
        else
        {
            EnableHightlight();
        }
    }

    public void DisableHightlight()
    {
        GetComponent<Renderer>().material = legacyMaterial;
        highlighted = false;
    }

    public void EnableHightlight()
    {
        GetComponent<Renderer>().material = selectionMaterial;
        highlighted = true;
    }
	
}
