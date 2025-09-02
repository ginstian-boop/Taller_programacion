using UnityEngine;

public class Hueso : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

         private void OnTriggerEnter2D(Collider2D collision){


        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.AumentarPuntos();

            Destroy(this.gameObject);
        }

    }
       
    
}


