using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGrid : MonoBehaviour {
    
    public int size;
    public float gap = 1.5f;
    public GameObject cube;

    private List<CubeController> cubeControllers;

    public void Rotate()
    {
        foreach(CubeController c in cubeControllers)
        {
            c.RotateLeft();
        }
    }

	// Use this for initialization
	void Start () {
        cubeControllers = new List<CubeController>();
        Vector3 thisPos = transform.position;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Vector3 clonePos = new Vector3(thisPos.x + i * gap, thisPos.y, thisPos.z + j * gap);
                GameObject clone = Instantiate(cube, clonePos, transform.rotation, transform);

                if (!clone.GetComponent<CubeController>())
                {
                    clone.AddComponent<CubeController>();
                }
                cubeControllers.Add(clone.GetComponent<CubeController>());
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
