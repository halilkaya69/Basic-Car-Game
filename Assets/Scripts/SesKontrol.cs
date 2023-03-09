using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    [SerializeField]
    AudioClip motorPatlama;

    [SerializeField]
    AudioClip arabaPatlama;
    
    [SerializeField]
    AudioClip ates;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();

    }

    public void MotorPatlama()
    {


        audioSource.PlayOneShot(motorPatlama);



    }
    public void ArabaPatlama()
    {
        audioSource.PlayOneShot(arabaPatlama);

    }
    public void Ates()
    {

        audioSource.PlayOneShot(ates);


    }
}
