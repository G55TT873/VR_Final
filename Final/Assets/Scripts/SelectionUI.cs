using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;
using UnityEngine.EventSystems;

public class SelectionUI : MonoBehaviour
{
    public GameObject uiCanvas;
    private ARSelectionInteractable selectionInteractable;
    private bool isSelected = false;

    void Awake()
    {
        selectionInteractable = GetComponent<ARSelectionInteractable>();

        if (selectionInteractable != null)
        {
            selectionInteractable.selectEntered.AddListener(OnSelectEntered);
            selectionInteractable.selectExited.AddListener(OnSelectExited);
        }
    }

    private void Update()
    {
        if (isSelected && Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
                return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == this.transform)
                {
                    return;
                }
            }

            DeselectUI();
        }
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        isSelected = true;
        if (uiCanvas != null)
        {
            uiCanvas.SetActive(true);
        }
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
    }

    private void DeselectUI()
    {
        isSelected = false;
        if (uiCanvas != null)
        {
            uiCanvas.SetActive(false);
        }

        if (selectionInteractable != null && selectionInteractable.isSelected)
        {
            selectionInteractable.interactionManager.SelectExit((IXRSelectInteractor)selectionInteractable, (IXRSelectInteractable)selectionInteractable.firstInteractorSelecting);
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
