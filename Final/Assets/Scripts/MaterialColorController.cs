using UnityEngine;
using UnityEngine.UI;

public class MaterialColorController : MonoBehaviour
{
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;
    public Material targetMaterial; // Drag the shared material asset here

    void Start()
    {
        // Add listeners to the sliders
        redSlider.onValueChanged.AddListener(UpdateColor);
        greenSlider.onValueChanged.AddListener(UpdateColor);
        blueSlider.onValueChanged.AddListener(UpdateColor);

        // Apply initial color
        UpdateColor(0);
    }

    void UpdateColor(float _)
    {
        if (targetMaterial != null)
        {
            Color newColor = new Color(redSlider.value, greenSlider.value, blueSlider.value);
            targetMaterial.color = newColor;
        }
    }
}
