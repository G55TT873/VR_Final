using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class SelectionUI : MonoBehaviour
{
    public GameObject uiCanvas; // Assign your UI Canvas in the Inspector

    private ARSelectionInteractable selectionInteractable;

    void Awake()
    {
        selectionInteractable = GetComponent<ARSelectionInteractable>();

        if (selectionInteractable != null)
        {
            selectionInteractable.selectEntered.AddListener(OnSelectEntered);
            selectionInteractable.selectExited.AddListener(OnSelectExited);
        }
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (uiCanvas != null)
        {
            uiCanvas.SetActive(true);
        }
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        if (uiCanvas != null)
        {
            uiCanvas.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        if (selectionInteractable != null)
        {
            selectionInteractable.selectEntered.RemoveListener(OnSelectEntered);
            selectionInteractable.selectExited.RemoveListener(OnSelectExited);
        }
    }
}
