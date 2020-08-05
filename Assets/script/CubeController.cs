using System.Collections;
using UnityEngine;

public class CubeController : MonoBehaviour {

    public enum TURN_DIRECTION {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    private readonly float rotateSpeed = 0.15f;
    private readonly float angle = 90.0f;
    private bool rotating = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {}

    public void Rotate(CubeController.TURN_DIRECTION direction) {
        if (!rotating) {
            switch (direction) {
                case CubeController.TURN_DIRECTION.LEFT:
                    StartCoroutine(RotateAround(Vector3.forward, angle * -1, rotateSpeed));
                break;
                case CubeController.TURN_DIRECTION.RIGHT:
                    StartCoroutine(RotateAround(Vector3.forward, angle, rotateSpeed));
                break;
                case CubeController.TURN_DIRECTION.UP:
                    StartCoroutine(RotateAround(Vector3.right, angle * -1, rotateSpeed));
                break;
                case CubeController.TURN_DIRECTION.DOWN:
                    StartCoroutine(RotateAround(Vector3.right, angle, rotateSpeed));
                break;
            }
        }
    }

    public void RotateLeft() {
        if(!rotating)
            StartCoroutine(RotateAround(Vector3.forward, angle * -1, rotateSpeed));
    }

    public void RotateRight()
    {
        if (!rotating)
            StartCoroutine(RotateAround(Vector3.forward, angle, rotateSpeed));
    }

    public void RotateUp()
    {
        if (!rotating)
            StartCoroutine(RotateAround(Vector3.right, angle * -1, rotateSpeed));
    }

    public void RotateDown()
    {
        if (!rotating)
            StartCoroutine(RotateAround(Vector3.right, angle, rotateSpeed));
    }

    public Quaternion GetRotation()
    {
        return transform.localRotation;
    }

    private IEnumerator RotateAround(Vector3 axis, float angle, float duration)
    {
        float elapsed = 0.0f;
        float rotated = 0.0f;

        rotating = true;
        while (elapsed + Time.deltaTime < duration)
        {
            float step = angle / duration * Time.deltaTime;
            transform.RotateAround(transform.position, axis, step);
            elapsed += Time.deltaTime;
            rotated += step;
            yield return null;
        }
        transform.RotateAround(transform.position, axis, angle - rotated);
        rotating = false;
    }
}
