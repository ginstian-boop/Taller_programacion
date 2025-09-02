using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float jump = 500;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            {

        rb.AddForce(new Vector2(0, 1) * jump);
    }
     
        if (Input.GetKey(KeyCode.A))
        { 
        rb.AddForce(new Vector2(-1, 0) *6);
            }
        if (Input.GetKey(KeyCode.D))
        {

            rb.AddForce(new Vector2(1, 0) *6);
        }
    }
}
