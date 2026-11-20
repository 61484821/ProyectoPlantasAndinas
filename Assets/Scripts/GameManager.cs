using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text textoPlantas;
    public TMP_Text textoMonedas;
    public GameObject panelFinal;
    public int totalPlantas = 5;

    int plantas, monedas;

    void Awake() { Instance = this; }
    void Start() { ActualizarUI(); }

    public void Sumar(TipoItem tipo)
    {
        if (tipo == TipoItem.Planta) plantas++;
        else monedas++;

        ActualizarUI();

        if (plantas >= totalPlantas) panelFinal.SetActive(true);
    }

    void ActualizarUI()
    {
        textoPlantas.text = "Plantas: " + plantas + "/" + totalPlantas;
        textoMonedas.text = "Monedas: " + monedas;
    }
}