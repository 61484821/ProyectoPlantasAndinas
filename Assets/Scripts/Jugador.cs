using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 12f;
    public Transform chequeoSuelo;
    public LayerMask capaSuelo;

    Rigidbody2D rb;
    bool enSuelo;

    void Awake() { rb = GetComponent<Rigidbody2D>(); }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(h * velocidad, rb.linearVelocity.y);

        enSuelo = Physics2D.OverlapCircle(chequeoSuelo.position, 0.15f, capaSuelo);

        if (Input.GetButtonDown("Jump") && enSuelo)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
    }
}