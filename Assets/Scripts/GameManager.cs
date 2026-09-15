using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverText;
    public Button reiniciarButton;
    public Button menuButton;

    [Header("Monedas")]
    public int monedas = 0;
    public TextMeshProUGUI textoMonedas;

    private bool gameOverActivo = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        if (reiniciarButton != null)
            reiniciarButton.onClick.AddListener(ReiniciarEscena);

        if (menuButton != null)
            menuButton.onClick.AddListener(IrAlMenu);

        CargarMoneda();
        ActualizarMonedasUI();
    }

    void Update()
    {
        if (gameOverActivo)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                ReiniciarEscena();
            }

            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.M))
            {
                IrAlMenu();
            }
        }
    }

    public void SumarMoneda(int cantidad)
    {
        monedas+=cantidad;
        ActualizarMonedasUI();
        GuardarMoneda();
    }
    void ActualizarMonedasUI()
    {
        if (textoMonedas != null)
        {
            textoMonedas.text = "x" + monedas.ToString();
        }
    }

    void GuardarMoneda()
    {
        PlayerPrefs.SetInt("Monedas", monedas);
        PlayerPrefs.Save();
    }

    void CargarMoneda()
    {
        monedas=PlayerPrefs.GetInt("Monedas", 0);
    }

    public void GameOver()
    {
        if (gameOverActivo) return;

        gameOverActivo = true;

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        
    }

    public void ReiniciarEscena()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void IrAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}