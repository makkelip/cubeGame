using UnityEngine;

public class Cotroller : MonoBehaviour
{

    public GameObject cube;

    private CubeController cubeController;

    // Use this for initialization
    void Start()
    {
        cubeController = cube.GetComponent<CubeController>();
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
