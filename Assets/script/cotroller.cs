using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cotroller : MonoBehaviour
{
    private float rotateSpeed = 0.15f;
    private float angle = 90.0f;
    private bool rotating = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!rotating)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                StartCoroutine(RotateAround(Vector3.right, angle, rotateSpeed));
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                StartCoroutine(RotateAround(Vector3.right, angle * -1, rotateSpeed));
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                StartCoroutine(RotateAround(Vector3.forward, angle, rotateSpeed));
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                StartCoroutine(RotateAround(Vector3.forward, angle * -1, rotateSpeed));
            }
        }
    }

    IEnumerator RotateAround(Vector3 axis, float angle, float duration)
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
