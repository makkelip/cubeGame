using System;
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
    void Update() { }

    public IEnumerator Rotate(CubeController.TURN_DIRECTION direction, Action callback) {
        switch (direction) {
            case CubeController.TURN_DIRECTION.LEFT:
                return RotateAround(Vector3.up, angle * -1, rotateSpeed, callback);
            case CubeController.TURN_DIRECTION.RIGHT:
                return RotateAround(Vector3.up, angle, rotateSpeed, callback);
            case CubeController.TURN_DIRECTION.UP:
                return RotateAround(Vector3.right, angle, rotateSpeed, callback);
            case CubeController.TURN_DIRECTION.DOWN:
                return RotateAround(Vector3.right, angle * -1, rotateSpeed, callback);
            default:
                return null;
        }
    }

    public Quaternion GetRotation() {
        return transform.localRotation;
    }

    private IEnumerator RotateAround(Vector3 axis, float angle, float duration, Action callback) {
        yield return RotateAround(axis, angle, duration);
        callback.Invoke();
    }

    private IEnumerator RotateAround(Vector3 axis, float angle, float duration) {
        float elapsed = 0.0f;
        float rotated = 0.0f;

        rotating = true;
        while (elapsed + Time.deltaTime < duration) {
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
