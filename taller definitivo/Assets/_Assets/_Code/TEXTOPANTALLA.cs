using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class tallerVariables : MonoBehaviour
{

    [SerializeField]

    private GameObject puerta;

    [SerializeField]
    private GameObject tramp;
    [SerializeField]
    private GameObject obs;
    [SerializeField]
    private int vida = 3;
    [SerializeField]
    private int puntos = 0;

    [SerializeField]
    private float tiempo = 60f;

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

        llavetext.text = "Llave?  " + llave;




    }
    void Update()
    {

        tiempo -= Time.deltaTime;
        tiempoText.text = "Tiempo :  " + tiempo.ToString("f0");

        if (tiempo <= 0)
        {
            SceneManager.LoadScene(1);

        }






        if (puntos >= 10)
        {

            Destroy(obs);

        }

        if (vida <= 0)
        {
            SceneManager.LoadScene(1);
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

    public void sumarTiempo()
    {
        tiempo += 5;

    }

    public void ponerllave()
    {
        llave = true;

        llavetext.text = "Llave?  " + llave;
    }
    
    public void Abrirpuerta()
    {
        if (llave == true)
        {
             SceneManager.LoadScene(2);
        }
    }
}


