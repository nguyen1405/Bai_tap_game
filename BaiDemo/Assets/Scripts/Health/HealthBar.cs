using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health health;
    private RectTransform maskRect;
    private float originalWidth;

    void Start()
    {
        maskRect = GetComponent<RectTransform>();
        originalWidth = maskRect.sizeDelta.x;
        if (health != null)
        {
            health.onHealthChanged += UpdateHealthBar;
        }
    }

    void UpdateHealthBar()
    {
        float percent = health.GetHealthPercent();
        maskRect.sizeDelta = new Vector2(originalWidth * percent, maskRect.sizeDelta.y);
    }
    private void OnDestroy()
    {
        if (health != null)
        {
            health.onHealthChanged -= UpdateHealthBar;
        }
    }
}