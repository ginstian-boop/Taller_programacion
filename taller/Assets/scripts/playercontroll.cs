using System.Numerics;
using UnityEngine;

public class playercontroll : MonoBehaviour
{


    private bool _isjumping ;
    [SerializeField]
    private float _jumpforce = 8f;
    [SerializeField]
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !_isjumping)
        {
            rb.AddForce(new UnityEngine.Vector2(0f, 1f) * _jumpforce);
            _isjumping = true;

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new UnityEngine.Vector2(-1, 0) * 6);


        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new UnityEngine.Vector2(1, 0) * 6);


        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        _isjumping = false;
    }
}
