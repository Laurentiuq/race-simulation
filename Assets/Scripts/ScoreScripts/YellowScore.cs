using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerEnter() {
        audioSource.Play();
        ScoreMode.CurrentScore += 25;
        Invoke("Disable", 1.0f);
        
    }

    private void Disable(){
        gameObject.SetActive(false);
    }
}
