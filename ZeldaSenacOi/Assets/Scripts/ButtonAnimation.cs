using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{
    public RectTransform button; // Refer�ncia ao bot�o
    public float tiltAmount = 10f; // Quanto ele inclina
    public float tiltSpeed = 2f; // Velocidade da anima��o
    public float scaleAmount = 1.2f; // Tamanho quando o mouse estiver em cima

    private Vector3 originalScale;
    private bool isHovered = false;

    void Start()
    {
        if (button == null)
            button = GetComponent<RectTransform>();

        originalScale = button.localScale;
    }

    void Update()
    {
        // Detecta se o mouse est� sobre o bot�o
        Vector2 mousePosition = Input.mousePosition;
        isHovered = RectTransformUtility.RectangleContainsScreenPoint(button, mousePosition);

        if (isHovered)
        {
            button.rotation = Quaternion.identity; // Para a rota��o
            button.localScale = originalScale * scaleAmount; // Aumenta o tamanho
        }
        else
        {
            float angle = Mathf.Sin(Time.time * tiltSpeed) * tiltAmount;
            button.rotation = Quaternion.Euler(0, 0, angle);
            button.localScale = originalScale; // Volta ao tamanho normal
        }
    }
}