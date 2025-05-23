using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public Animator Animator; // Assign the Animator that controls your panel
    public Animator Animator2;
    // Call this from the "Open" button
    public void Open()
    {
        Animator.SetBool("Open", true);
        Animator2.SetBool("Open", true);

    }

    // Call this from the "Close" button
    public void Close()
    {
        Animator.SetBool("Open", false);
        Animator2.SetBool("Open", false);
    }
}
