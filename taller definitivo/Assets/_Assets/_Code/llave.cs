using UnityEngine;

public class llave : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            GameManager._gm.tienellave();

            Destroy(this.gameObject);
        }

    }
}
