using UnityEngine;

public class UnderwaterSound : MonoBehaviour
{
    public AudioLowPassFilter lowPassFilter;
    public float underwaterCutoffFrequency = 500f; // Frequency for underwater effect
    public float normalCutoffFrequency = 22000f; // Normal frequency

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            // Apply underwater effect
            lowPassFilter.cutoffFrequency = underwaterCutoffFrequency;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            // Revert to normal sound
            lowPassFilter.cutoffFrequency = normalCutoffFrequency;
        }
    }
}