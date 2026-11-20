using UnityEngine;

public enum TipoItem { Planta, Moneda }

public class Recolectable : MonoBehaviour
{
    public TipoItem tipo;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.Sumar(tipo);
            Destroy(gameObject);
        }
    }
}