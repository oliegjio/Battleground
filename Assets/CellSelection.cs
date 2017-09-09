using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellSelection : MonoBehaviour
{

    public RaycastHit hit;

    void Update()
    {
		if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100f) && hit.transform.tag == "Cell")
            {
                GameObject[] cells = GameObject.FindGameObjectsWithTag("Cell");
                Cell cellScript = hit.transform.gameObject.GetComponent<Cell>();
                for (int i = 0; i < cells.Length; i++)
                {
                    cells[i].GetComponent<Cell>().DisableHightlight();
                }
                cellScript.ToggleHightlight();
            }
        }
	}
}
