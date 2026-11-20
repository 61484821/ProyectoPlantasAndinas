using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    public void Jugar() { SceneManager.LoadScene("Nivel1"); }
    public void Salir() { Application.Quit(); }
}