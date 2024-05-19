using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerEnter() {
        audioSource.Play();
        ScoreMode.CurrentScore += 50;
        Invoke("Disable", 1.0f);
        
    }
    private void Disable(){
        gameObject.SetActive(false);
    }
    
}

