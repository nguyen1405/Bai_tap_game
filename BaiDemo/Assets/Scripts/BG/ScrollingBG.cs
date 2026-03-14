using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] private float speed = 0.2f;
    private Renderer bgRenderer;

    void Start()
    {
        bgRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * speed;
        bgRenderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}