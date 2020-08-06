using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CubeController;

public class CubeGrid : MonoBehaviour {
    
    public int size;
    public float distance = 1.5f;
    public GameObject cube;

    private List<CubeController> cubeControllers;
    private int noOfCubesRotating = 0;

    private bool IsRotating() {
        return noOfCubesRotating > 0;
    }

    private void RotateRow(int row, CubeController.TURN_DIRECTION direction) {
        if (IsRotating()) return;

        for (int i = 0; i < size; i++) {
            noOfCubesRotating++;
            StartCoroutine(cubeControllers[row + (i * size)].Rotate(direction, () => noOfCubesRotating--));
        }
    }

    private void RotateColumn(int column, CubeController.TURN_DIRECTION direction) {
        if (IsRotating()) return;

        for (int i = 0; i < size; i ++) {
            noOfCubesRotating++;
            StartCoroutine(cubeControllers[(column * size) + i].Rotate(direction, () => noOfCubesRotating--));
        }
    }

    public void RotateRowUp(int row) {
        RotateRow(row, CubeController.TURN_DIRECTION.UP);
    }

    public void RotateRowDown(int row) {
        RotateRow(row, CubeController.TURN_DIRECTION.DOWN);
    }

    public void RotateColumnLeft(int column) {
        RotateColumn(column, CubeController.TURN_DIRECTION.LEFT);
    }

    public void RotateColumnRight(int column) {
        RotateColumn(column, CubeController.TURN_DIRECTION.RIGHT);
    }

    // Use this for initialization
    void Start () {
        if (transform.childCount > 0) return;

        cubeControllers = new List<CubeController>();

        Vector2 firstCubePos = new Vector2(
            transform.position.x - size / 2 * distance,
            transform.position.y - size / 2 * distance
        );

        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                Vector3 clonePos = new Vector3(
                    firstCubePos.x + i * distance,
                    firstCubePos.y + j * distance,
                    transform.position.z
                );
                GameObject clone = Instantiate(cube, clonePos, transform.rotation, transform);

                if (!clone.GetComponent<CubeController>()) {
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
