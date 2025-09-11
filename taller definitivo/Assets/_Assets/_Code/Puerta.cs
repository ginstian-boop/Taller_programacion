using UnityEngine;

public class Puerta : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (GameManager._gm != null)
            {
                GameManager._gm.abrirpuerta();
            }
        }
    }

   

}
