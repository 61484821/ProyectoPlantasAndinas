using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public static Vidas instancia;
    public Image[] corazones;
    public int vidasMaximas = 5;
    public Color colorLleno = new Color(0.95f, 0.72f, 0.71f, 1f);
    public Color colorVacio = new Color(0.3f, 0.3f, 0.3f, 0.5f);

    int vidasActuales;

    void Awake()
    {
        instancia = this;
        vidasActuales = vidasMaximas;
        Actualizar();
    }

    // Devuelve true si se acabaron las vidas y se reinicia el nivel
    public bool PerderVida()
    {
        vidasActuales--;
        Actualizar();
        if (vidasActuales <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            return true;
        }
        return false;
    }

    void Actualizar()
    {
        for (int i = 0; i < corazones.Length; i++)
            corazones[i].color = i < vidasActuales ? colorLleno : colorVacio;
    }
}