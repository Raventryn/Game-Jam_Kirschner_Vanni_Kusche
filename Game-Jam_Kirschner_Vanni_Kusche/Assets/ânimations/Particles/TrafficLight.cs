using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsingLight : MonoBehaviour
{
    // Minimum and maximum values
    public float minIntensity = 0f;
    public float maxIntensity = 1f;

    // Pulsing speed
    public float pulseSpeed = 1f;

    // Reference to the Light component
    private Light lightComponent;

    void Start()
    {
        // Get the Light component attached to this GameObject
        lightComponent = GetComponent<Light>();
    }

    void Update()
    {
        // Calculate the new intensity using a sine wave
        float intensity = Mathf.Lerp(minIntensity, maxIntensity, (Mathf.Sin(Time.time * pulseSpeed) + 1f) / 2f);

        // Set the light intensity
        lightComponent.intensity = intensity;
    }
}
