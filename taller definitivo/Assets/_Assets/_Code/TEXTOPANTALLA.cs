using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tallerVariables : MonoBehaviour
{

    [SerializeField]
    private GameObject tramp;
    [SerializeField]
    private GameObject obs;
    [SerializeField]
    private int vida = 3;
    [SerializeField]
    private int puntos = 0;
    
    [SerializeField]
    private bool llave = false;


    [Header("Varibles Unity")]
    [SerializeField]
    private TMP_Text vidaText;
    [SerializeField]
    private TMP_Text puntosText;
    [SerializeField]
    private TMP_Text tiempoText;
    [SerializeField]
    private TMP_Text llavetext;


    void Start()
    {

        vidaText.text = "Vida : " + vida;
        puntosText.text = "Puntos : " + puntos;
        tiempoText.text = "Tiempo :  " + tiempo;
        llavetext.text = "Llave?  " + llave;




    }
    void Update()
    {
        if (puntos >= 10)
        {

            Destroy(obs);

        }

        if (vida <= 0)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(1);
        }




    }
    public void SumarPuntos()
    {
        puntos++;
        puntosText.text = "Puntos : " + puntos;
    }


    public void restarvida()
    {
        vida--;
        vidaText.text = "Vida : " + vida;
    }
    public void Sumarvida()
    {
        vida++;
        vidaText.text = "Vida : " + vida;
    }
}


