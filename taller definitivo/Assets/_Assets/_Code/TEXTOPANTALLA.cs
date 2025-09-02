using TMPro;
using UnityEngine;


public class tallerVariables : MonoBehaviour
{
    [SerializeField]
    private int vida = 3;
    [SerializeField]
    private int puntos = 0;
    [SerializeField]
    private float tiempo = 60f;
    [SerializeField]
    private bool llave = true;


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





    }
    public void SumarPuntos()
    {
        puntos++;
        puntosText.text = "Puntos : " + puntos;
    }
    }

