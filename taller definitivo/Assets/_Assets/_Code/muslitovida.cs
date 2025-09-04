using UnityEngine;

public class muslitovida : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            GameManager._gm.sumarvida();

            Destroy(this.gameObject);
        }

    }
}