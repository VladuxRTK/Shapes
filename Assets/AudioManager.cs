using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] attackSFX;

    private AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio(string audioClip)
    {
        switch (audioClip)
        {
            case "laserAttack":
                myAudio.PlayOneShot(attackSFX[Random.Range(0,3)]);
                break;
        }  
    }
}
