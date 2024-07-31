using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isPlayer1; // Define se é o Player 1 ou Player 2
    public float pullForce = 10f; // Força de puxar a corda
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isPlayer1 && Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(Vector2.left * pullForce);
        }
        else if (!isPlayer1 && Input.GetKey(KeyCode.E))
        {
            rb.AddForce(Vector2.right * pullForce);
        }
    }
}
