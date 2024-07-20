using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
        public AudioSource audioSource;

    void Start()
    {
        // Obtener el componente AudioSource del objeto
        audioSource = GetComponent<AudioSource>();

        // Asegurarse de que el audio se reproduzca en bucle
        if (audioSource != null)
        {
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        Debug.Log("Saliendo del Juego");
        Application.Quit();
    }
}
