using UnityEngine;
 public class PlayerController :MonoBehaviour
 {
    // Velocidade da bola. "public" faz aparecer no Inspector.
    public float speed = 10f;

    // Referência para o Rigidbody (a física da bola)
    private Rigidbody rb;

    // Start roda UMA vez, quando o jogo começa
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate roda em intervalos fixos: ideal para física
    void FixedUpdate()
    {
      // Teclas A e D (ou setas esquerda/direita): valor de -1 a 1
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Teclas W e S (ou setas cima/baixo): valor de -1 a 1
        float moveVertical = Input.GetAxis("Vertical");

        // X = esquerda/direita, Y = 0 (não voa), Z = frente/trás
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Empurra a bola na direção apertada
        rb.AddForce(movement * speed);
    }
}

