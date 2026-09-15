using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Zona de muerte activada");
            collision.GetComponent<PlayerController>().RecibeDanio(Vector2.zero, 999);
        }
    }
}
