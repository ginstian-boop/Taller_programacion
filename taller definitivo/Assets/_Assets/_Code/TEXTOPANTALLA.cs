using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class tallerVariables : MonoBehaviour
{
    [SerializeField]
    private Image[] spriteSCorazon;

    [SerializeField]
    private int vidaMaxima = 5;

    [SerializeField]
    private GameObject[] corazones;



    [SerializeField]
    private GameObject llaveHud;
    [SerializeField]
    private GameObject puerta;

    [SerializeField]
    private GameObject tramp;
    [SerializeField]
    private GameObject obs;
    [SerializeField]
    private int vida = 5;
    [SerializeField]
    private int puntos = 0;

    [SerializeField]
    private float tiempo = 60f;

    [SerializeField]
    private bool llave = false;


    [SerializeField]
   private GameObject panelPausa;




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

        ActualizarLlaveHUD();
        ActualizarCorazones();
        if (panelPausa != null)
            panelPausa.SetActive(false);
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
        ActualizarCorazones() ;
    }
    public void Sumarvida()
    {
        vida++;
        vidaText.text = "Vida : " + vida;
        ActualizarCorazones();
    }

    public void sumarTiempo()
    {
        tiempo += 5;

    }

    public void ponerllave()
    {
        llave = true;

        ActualizarLlaveHUD();
    }
    private void ActualizarLlaveHUD()
    {

        if (llaveHud != null)
        {
            llaveHud.SetActive(llave);
        }
    }


    public void Abrirpuerta()
    {
        if (llave == true)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void EstadoDeJuego(string estado)
    {
        switch (estado)
        {
            case "play":
                Time.timeScale = 1;
                if (panelPausa != null)
                    panelPausa.SetActive(false);
                break;

            case "Pause":
                Time.timeScale = 0;
                if (panelPausa != null)
                    panelPausa.SetActive(true);
                break;

            case "Ganaste":
                SceneManager.LoadScene("Ganaste");
                Time.timeScale = 1;
                break;

            case "Perdiste":
                SceneManager.LoadScene("Perdiste");
                Time.timeScale = 1;
                break;

            case "Exit":
                Application.Quit();
       #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
                break;
        }
    }
    private void ActualizarCorazones()
    {
        for (int i = 0; i < corazones.Length; i++)
        {
            if (corazones[i] != null)
            {

                corazones[i].SetActive(i < vida);
            }
        }
    }

    public void restarvidaa()
    {
        vida--;
        ActualizarCorazones();
    }

    public void Sumarvidaa()
    {
        if (vida < vidaMaxima)
        {
            vida++;
            ActualizarCorazones(); 
        }
    }
}


