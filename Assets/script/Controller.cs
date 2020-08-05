using UnityEngine;

public class Controller : MonoBehaviour {
    private CubeGrid cubeGrid;

    // Use this for initialization
    void Start() {
        cubeGrid = GameObject.FindObjectOfType<CubeGrid>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            cubeGrid.RotateRowUp(0);
        } else if (Input.GetKeyDown(KeyCode.Q)) {
            cubeGrid.RotateRowDown(0);
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            cubeGrid.RotateRowUp(1);
        } else if (Input.GetKeyDown(KeyCode.W)) {
            cubeGrid.RotateRowDown(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            cubeGrid.RotateRowUp(2);
        } else if (Input.GetKeyDown(KeyCode.E)) {
            cubeGrid.RotateRowDown(2);
        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            cubeGrid.RotateColumnLeft(0);
        } else if (Input.GetKeyDown(KeyCode.R)) {
            cubeGrid.RotateColumnRight(0);
        } else if (Input.GetKeyDown(KeyCode.Alpha5)) {
            cubeGrid.RotateColumnLeft(1);
        } else if (Input.GetKeyDown(KeyCode.T)) {
            cubeGrid.RotateColumnRight(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha6)) {
            cubeGrid.RotateColumnLeft(2);
        } else if (Input.GetKeyDown(KeyCode.Y)) {
            cubeGrid.RotateColumnRight(2);
        }
    }
}
