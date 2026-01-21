using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Slider healthSlider;  // Kéo Slider vào đây

    // Public method này sẽ binding trong Inspector
    public void UpdateHealthBar(float normalizedHealth)
    {
        if (healthSlider != null)
        {
            healthSlider.value = normalizedHealth;
        }
    }
}