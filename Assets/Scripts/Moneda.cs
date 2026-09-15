using System.Collections;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int valor = 1;
    public AudioSource audioSource;
    public AudioClip sonidoMoneda;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.SumarMoneda(valor);
            StartCoroutine(ReproducirYDestruir());
        }
    }

    private IEnumerator ReproducirYDestruir()
    {
        // Ocultar la moneda visualmente y desactivar colisión
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        // Reproducir el sonido
        audioSource.PlayOneShot(sonidoMoneda);

        // Esperar a que termine el audio
        yield return new WaitForSeconds(sonidoMoneda.length);

        Destroy(gameObject);
    }
}