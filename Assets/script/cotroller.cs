using UnityEngine;

public class Cotroller : MonoBehaviour
{

    public GameObject cubeGrid;

    private CubeGrid cubeController;

    // Use this for initialization
    void Start()
    {
        cubeController = cubeGrid.GetComponent<CubeGrid>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            cubeController.Rotate();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
        }
    }
}
