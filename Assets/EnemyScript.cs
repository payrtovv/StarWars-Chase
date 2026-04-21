using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float velocidad = 3f;

    public float limiteX = 2.5f;
    public float limiteY = 1.5f;

    public float tiempoCambio = 1.5f;

    private int direccionX;
    private int direccionY;
    private float timer;

    void Start()
    {
        direccionX = Random.value > 0.5f ? 1 : -1;
        direccionY = Random.value > 0.5f ? 1 : -1;
    }

    void Update()
    {
        // Movimiento en X y Y
        transform.Translate(new Vector2(direccionX, direccionY) * velocidad * Time.deltaTime);

        // Timer para cambiar dirección aleatoriamente
        timer += Time.deltaTime;
        if (timer >= tiempoCambio)
        {
            CambiarDireccion();
            timer = 0f;
        }

        // Límites X
        if (transform.position.x >= limiteX)
            direccionX = -1;
        else if (transform.position.x <= -limiteX)
            direccionX = 1;

        // Límites Y
        if (transform.position.y >= limiteY)
            direccionY = -1;
        else if (transform.position.y <= -limiteY)
            direccionY = 1;
    }

    void CambiarDireccion()
    {
        // Cambia X o Y aleatoriamente
        if (Random.value > 0.5f)
            direccionX *= -1;

        if (Random.value > 0.5f)
            direccionY *= -1;
    }
}