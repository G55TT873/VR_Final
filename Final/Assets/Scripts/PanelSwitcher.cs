using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject panelA;  // The current panel
    public GameObject panelB;  // The next panel to show

    public void SwitchPanels()
    {
        if (panelA != null)
            panelA.SetActive(false);
        
        if (panelB != null)
            panelB.SetActive(true);
    }
}
