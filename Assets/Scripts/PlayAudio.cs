using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayAudio : MonoBehaviour {

    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio(){
        audioSource.Play();
    }
}
