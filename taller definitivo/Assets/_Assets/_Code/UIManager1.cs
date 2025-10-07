using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager1 : MonoBehaviour
{

    void estadodejuego(string estado)
    {


        switch (estado)
        {
            case "PLAY2":

                SceneManager.LoadScene(0);

                break;
        }

    }

 
}
