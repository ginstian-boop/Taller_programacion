using UnityEngine;
using UnityEngine.SceneManagement;

public class Trampa : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (GameManager._gm != null)
            {
                GameManager._gm.restarvida(); 
            }
        }
    }
}

