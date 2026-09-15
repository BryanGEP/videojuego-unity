using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocion : MonoBehaviour
{
    public int curacion = 1;
    public AudioSource audioSource;
    public AudioClip sonidoPocion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.CurarVida(curacion);
            StartCoroutine(ReproducirYDestruir());
        }
    }

    private IEnumerator ReproducirYDestruir()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        audioSource.PlayOneShot(sonidoPocion);

        yield return new WaitForSeconds(sonidoPocion.length);

        Destroy(gameObject);
    }
}