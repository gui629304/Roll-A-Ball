using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Arraste o player para este campo no Inspector
    public GameObject player;

    // Distancia entre a camera e a bola 
    private Vector3 offset;

    void Start()
    {
        // Calcula a distancia inicial camera -> bola
        offset = transform.position - player.transform.position;
    }

    // LateUpdate roda depois que tudo se moveu no frame
    void LateUpdate()
    {
        // A camera vai para a posição da bola + a distancia 
        transform.position = player.transform.position + offset;
    }
}