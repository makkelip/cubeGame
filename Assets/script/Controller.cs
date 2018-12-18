using UnityEngine;

public class Controller : MonoBehaviour
{
    private GameObject cubeGrid;

    private CubeGrid cubeController;

    // Use this for initialization
    void Start()
    {
        cubeController = GameObject.FindObjectOfType<CubeGrid>();
        //cubeController = cubeGrid.GetComponent<CubeGrid>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            cubeController.RotateUp();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            cubeController.RotateDown();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            cubeController.RotateLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            cubeController.RotateRight();
        }
    }
}
