using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{
    public RectTransform button; // Referência ao botão
    public float tiltAmount = 10f; // Quanto ele inclina
    public float tiltSpeed = 2f; // Velocidade da animação
    public float scaleAmount = 1.2f; // Tamanho quando o mouse estiver em cima

    private bool isHovered = false;
    private Vector3 originalScale;

    void Start()
    {
        if (button == null)
            button = GetComponent<RectTransform>();

        originalScale = button.localScale;
    }

    void Update()
    {
        if (!isHovered)
        {
            float angle = Mathf.Sin(Time.time * tiltSpeed) * tiltAmount;
            button.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    public void OnPointerEnter()
    {
        isHovered = true;
        button.rotation = Quaternion.identity; // Reseta a rotação
        button.localScale = originalScale * scaleAmount; // Aumenta o tamanho
    }

    public void OnPointerExit()
    {
        isHovered = false;
        button.localScale = originalScale; // Volta ao tamanho normal
    }
}
