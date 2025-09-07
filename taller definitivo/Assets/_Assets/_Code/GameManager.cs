
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{

    public static GameManager _gm;

    public tallerVariables uiManager;

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

    public void mastiempo()
    {

        uiManager.sumarTiempo();

    }

    public void tienellave()
    {

        uiManager.ponerllave(); 

    }
public void abrirpuerta()
    {

        uiManager.Abrirpuerta();

    }
}
