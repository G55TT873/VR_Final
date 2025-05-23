using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class SinglePlacementController : MonoBehaviour
{
    private ARPlacementInteractable placementInteractable;
    private bool hasPlaced = false;

    void Awake()
    {
        placementInteractable = GetComponent<ARPlacementInteractable>();
    }

    void OnEnable()
    {
        placementInteractable.objectPlaced.AddListener(OnObjectPlaced);
    }

    void OnDisable()
    {
        placementInteractable.objectPlaced.RemoveListener(OnObjectPlaced);
    }

    private void OnObjectPlaced(ARObjectPlacementEventArgs args)
    {
        if (hasPlaced)
            return;

        hasPlaced = true;

        // Disable further placements
        placementInteractable.enabled = false;

        Debug.Log("AR object placed. Disabling further placements.");
    }
}
