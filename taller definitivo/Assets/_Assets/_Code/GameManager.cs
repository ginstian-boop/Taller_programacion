
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public static GameManager _gm;

    public tallerVariables uiManager;

    public obstaculo obs;

    public Trampa tramp;





    private void Awake()
    {
        if (_gm == null)
        {
            _gm = this;
        }
    }


    public void AumentarPuntos()
    {
        uiManager.SumarPuntos();
    }

    public void restarvida()
    {

        uiManager.restarvida();

    }

    public void sumarvida()
    {

        uiManager.Sumarvida();

    }



}


