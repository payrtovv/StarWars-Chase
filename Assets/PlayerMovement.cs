using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Configuración de Velocidad")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        // Obtenemos el componente Rigidbody2D al iniciar
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0f;
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");

    }

    void FixedUpdate()
    {
        // Aplicamos la velocidad al Rigidbody
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}