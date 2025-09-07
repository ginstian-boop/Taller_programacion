using UnityEngine;

public class muslitotiempo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            GameManager._gm.mastiempo();

            Destroy(this.gameObject);
        }

    }
}