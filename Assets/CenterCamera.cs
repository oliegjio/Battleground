using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCamera : MonoBehaviour
{

	void Start()
    {
        int dimension = GameObject.Find("Brain").GetComponent<GridGenerator>().dimension;

        transform.position = new Vector3((dimension / 2) - 0.5f, dimension / 1.5f, -dimension / 2.5f);
        transform.rotation = Quaternion.Euler(45f, 0, 0);
	}
	
}
