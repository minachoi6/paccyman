using System.Collections;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip introbgm;
    public AudioClip NormalGhost;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoopClip()
    {
        //play intro bgm
        yield return new WaitForSeconds(3);
        
        //start looping ghost
    }
}
