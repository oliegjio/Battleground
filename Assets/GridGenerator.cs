using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{

    public int dimension = 10;
	
	void Start()
    {
        GameObject CellPrefab = Resources.Load("CellPrefab") as GameObject;

        for (int i = 0; i < dimension; i++)
        {
            for (int k = 0; k < dimension; k++)
            {
                GameObject cell = Instantiate(CellPrefab);
                cell.tag = "Cell";
                cell.name = "Cell[" + k + ":" + i + "]";
                cell.transform.position = new Vector3(i, 0, k);
                if (i % 2 == 0 && k % 2 != 0)
                {
                    cell.transform.localScale = new Vector3(cell.transform.localScale.x, 0.1f, cell.transform.localScale.z);
                }
                if (i % 2 == 0 && k % 2 == 0)
                    {
                    cell.transform.localScale = new Vector3(cell.transform.localScale.x, 0.01f, cell.transform.localScale.z);
                }
                if (i % 2 != 0 && k % 2 != 0)
                {
                    cell.transform.localScale = new Vector3(cell.transform.localScale.x, 0.01f, cell.transform.localScale.z);
                }
                if (i % 2 != 0 && k % 2 == 0)
                {
                    cell.transform.localScale = new Vector3(cell.transform.localScale.x, 0.1f, cell.transform.localScale.z);
                }
            }
        }
	}

}
