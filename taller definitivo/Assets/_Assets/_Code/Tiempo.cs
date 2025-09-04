using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerSimple : MonoBehaviour
{
    [SerializeField] private TMP_Text tiempoText; 
    [SerializeField] private float tiempoInicial = 60f;

    private float tiempoRestante;

    void Start()
    {
        tiempoRestante = tiempoInicial;
        ActualizarTiempoUI();
    }

    void Update()
    {
        tiempoRestante -= Time.deltaTime;
        ActualizarTiempoUI();

        if (tiempoRestante <= 0f)
        {
            tiempoRestante = 0f;
            ReiniciarEscena();
        }
    }

    private void ActualizarTiempoUI()
    {
        if (tiempoText != null)
        {
            // Mostrar solo segundos (sin minutos)
            int segundos = Mathf.FloorToInt(tiempoRestante);
            tiempoText.text = "Tiempo: " + segundos.ToString();

            // Cambiar color cuando queda poco tiempo
            if (tiempoRestante < 10f)
            {
                tiempoText.color = Color.red;
            }
        }
    }

    private void ReiniciarEscena()
    {
        Debug.Log("¡Tiempo agotado! Reiniciando escena...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AgregarTiempo(float segundosExtra)
    {
        tiempoRestante += segundosExtra;
        Debug.Log("+ " + segundosExtra + " segundos!");
    }

    public float ObtenerTiempoRestante()
    {
        return tiempoRestante;
    }
}