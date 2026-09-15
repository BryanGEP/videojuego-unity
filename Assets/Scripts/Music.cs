using UnityEngine;

public class Music: MonoBehaviour
{
    public AudioClip musicaFondo;
    public float volumen = 0.5f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = musicaFondo;
        audioSource.loop = true;
        audioSource.volume = volumen;
        audioSource.Play();
    }
}