using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    public Collider2D coli;
    [SerializeField]
    SpriteRenderer sprite;

    void Start()
    {
        coli = GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

 
    void Update()
    {
        
    }
}
