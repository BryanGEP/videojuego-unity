using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonidoSaltar;
    public AudioClip sonidoRecibirDano;
    public AudioClip sonidoAtacar;
    public AudioClip sonidoCaida;
    public AudioClip sonidoMorir;

    public void playSaltar() 
    {
        audioSource.PlayOneShot(sonidoSaltar);    
    }

    public void playRecibirDano() 
    {
        audioSource.PlayOneShot(sonidoRecibirDano);
    }

    public void playAtacar() 
    {
        audioSource.PlayOneShot(sonidoAtacar);
    }

    public void playCaida() 
    {
        audioSource.PlayOneShot(sonidoCaida);
    }

    public void playMorir() 
    {
        audioSource.PlayOneShot(sonidoMorir);
    }
}
