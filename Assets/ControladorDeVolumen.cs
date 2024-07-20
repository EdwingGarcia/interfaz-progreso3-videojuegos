using UnityEngine;
using UnityEngine.UI;

public class ControladorDeVolumen : MonoBehaviour
{
    public Slider slider;
    private AudioSource audioSource;

    void Start()
    {
        // Obtener el componente AudioSource del objeto actual
        audioSource = GetComponent<AudioSource>();
        
        // Configurar el valor inicial del slider al volumen actual del audio
        if (audioSource != null && slider != null)
        {
            slider.value = audioSource.volume;
            slider.onValueChanged.AddListener(CambiarVolumen);
        }
    }

    // Método para cambiar el volumen
    public void CambiarVolumen(float valor)
    {
        if (audioSource != null)
        {
            audioSource.volume = valor;
        }
    }
}
