using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public tallerVariables uiManager;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AumentarPuntos()
    {
        uiManager.SumarPuntos();
    }
}

