using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public void IrAlMapa()
    {
        SceneManager.LoadScene("MapaNiveles");
    }
}