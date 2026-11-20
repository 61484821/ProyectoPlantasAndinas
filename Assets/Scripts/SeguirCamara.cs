using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    public Transform objetivo;
    void LateUpdate()
    {
        transform.position = new Vector3(objetivo.position.x, objetivo.position.y, -10f);
    }
}