using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonNivel : MonoBehaviour
{
    public string nombreEscena; // Ej: "Nivel_1"

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(nombreEscena);
        });
    }
}