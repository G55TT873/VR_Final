using UnityEngine;

public class ObjectSwitcher : MonoBehaviour
{
    public GameObject[] objects; // Drag your 3 objects here

   

    private void SwitchTo(int index)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i] != null)
                objects[i].SetActive(i == index);
        }
    }

    // Call this from Button 1
    public void ShowObject1()
    {
        SwitchTo(0);
    }

    // Call this from Button 2
    public void ShowObject2()
    {
        SwitchTo(1);
    }

    // Call this from Button 3
    public void ShowObject3()
    {
        SwitchTo(2);
    }
}
