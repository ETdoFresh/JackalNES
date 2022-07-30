using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private float delay = 1.5f;
    [SerializeField] private AudioSource introAudioSource;
    [SerializeField] private AudioSource loopAudioSource;
    
    private void Start()
    {
        StartCoroutine(PlayIntro());
    }
    
    private IEnumerator PlayIntro()
    {
        yield return new WaitForSeconds(delay);
        introAudioSource.Play();
        yield return new WaitForSeconds(introAudioSource.clip.length);
        loopAudioSource.Play();
    }
}
