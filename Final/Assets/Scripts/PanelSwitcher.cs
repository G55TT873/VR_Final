using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject panelA;
    public GameObject panelB;

    public void SwitchPanels()
    {
        if (panelA != null)
            panelA.SetActive(false);
        
        if (panelB != null)
            panelB.SetActive(true);
    }
}
