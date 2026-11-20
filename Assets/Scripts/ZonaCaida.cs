using UnityEngine;

public class ZonaCaida : MonoBehaviour
{
    public Transform puntoInicio;
    public float alturaMinima = -8f;

    void Update()
    {
        if (transform.position.y < alturaMinima)
        {
            Reiniciar();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rio"))
        {
            Reiniciar();
        }
    }

    void Reiniciar()
    {
        if (Vidas.instancia != null && Vidas.instancia.PerderVida())
            return; // se acabaron las vidas, la escena se reinicia

        transform.position = puntoInicio.position;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null) rb.linearVelocity = Vector2.zero;
    }
}