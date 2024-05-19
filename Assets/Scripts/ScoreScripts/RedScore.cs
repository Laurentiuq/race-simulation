using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour
{
    public AudioSource audioSource;

    [ContextMenu("TriggerSoundTest")]
    private void TriggerSoundTest(){
        audioSource.Play();
    }

    private void OnTriggerEnter() {
        audioSource.Play();
        ScoreMode.CurrentScore += 100;
        Invoke("Disable", 1.0f);
        
    }

    private void Disable(){
        gameObject.SetActive(false);
    }

}
