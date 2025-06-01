using UnityEngine;
using UnityEngine.EventSystems;

public class HoldToRotate : MonoBehaviour
{
    public Transform targetToRotate;
    public float rotationSpeed = 100f;
    private bool isRotating = false;

    void Update()
    {
        if (isRotating && targetToRotate != null)
        {
            targetToRotate.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }


    public void StartRotating()
    {
        isRotating = true;
    }

    public void StopRotating()
    {
        isRotating = false;
    }
}
