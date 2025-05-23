using UnityEngine;
using UnityEngine.EventSystems;

public class HoldToRotate : MonoBehaviour
{
    public Transform targetToRotate; // Assign the object to rotate in the Inspector
    public float rotationSpeed = 100f;
    private bool isRotating = false;

    void Update()
    {
        if (isRotating && targetToRotate != null)
        {
            targetToRotate.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    // Call this from Event Trigger → Pointer Down
    public void StartRotating()
    {
        isRotating = true;
    }

    // Call this from Event Trigger → Pointer Up
    public void StopRotating()
    {
        isRotating = false;
    }
}
