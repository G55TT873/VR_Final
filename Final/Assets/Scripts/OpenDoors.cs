using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public Animator Animator;
    public Animator Animator2;
    public void Open()
    {
        Animator.SetBool("Open", true);
        Animator2.SetBool("Open", true);

    }

    public void Close()
    {
        Animator.SetBool("Open", false);
        Animator2.SetBool("Open", false);
    }
}
