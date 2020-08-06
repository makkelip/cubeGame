using UnityEngine;

public class Controls : MonoBehaviour {
    private CubeGrid cubeGrid;

    // Use this for initialization
    void Start() {
        cubeGrid = GameObject.FindObjectOfType<CubeGrid>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            cubeGrid.RotateRowUp(0);
        } else if (Input.GetKeyDown(KeyCode.V)) {
            cubeGrid.RotateRowDown(0);
        } else if (Input.GetKeyDown(KeyCode.G)) {
            cubeGrid.RotateRowUp(1);
        } else if (Input.GetKeyDown(KeyCode.B)) {
            cubeGrid.RotateRowDown(1);
        } else if (Input.GetKeyDown(KeyCode.H)) {
            cubeGrid.RotateRowUp(2);
        } else if (Input.GetKeyDown(KeyCode.N)) {
            cubeGrid.RotateRowDown(2);
        } else if (Input.GetKeyDown(KeyCode.Q)) {
            cubeGrid.RotateColumnLeft(0);
        } else if (Input.GetKeyDown(KeyCode.W)) {
            cubeGrid.RotateColumnRight(0);
        } else if (Input.GetKeyDown(KeyCode.A)) {
            cubeGrid.RotateColumnLeft(1);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            cubeGrid.RotateColumnRight(1);
        } else if (Input.GetKeyDown(KeyCode.Z)) {
            cubeGrid.RotateColumnLeft(2);
        } else if (Input.GetKeyDown(KeyCode.X)) {
            cubeGrid.RotateColumnRight(2);
        }
    }
}
