using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapaNiveles : MonoBehaviour
{
    public Button[] botonesNivel;
    public bool desbloquearTodo = false;

    void Start()
    {
        int nivelMaximo = PlayerPrefs.GetInt("NivelMaximo", 1);

        for (int i = 0; i < botonesNivel.Length; i++)
        {
            int numero = i + 1;
            bool abierto = desbloquearTodo || numero <= nivelMaximo;

            botonesNivel[i].interactable = abierto;
            botonesNivel[i].onClick.RemoveAllListeners();
            botonesNivel[i].onClick.AddListener(() => IrANivel(numero));
        }
    }

    public void IrANivel(int numero)
    {
        string escena = "Nivel" + numero;
        if (Application.CanStreamedLevelBeLoaded(escena))
            SceneManager.LoadScene(escena);
        else
            Debug.Log(escena + " aún no existe (próximamente)");
    }

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}