using System.Collections;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    public AudioSource bgmPlayer;
    public AudioClip introbgm;
    public AudioClip normalGhostLoop;

    private float time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        time = 0;

        bgmPlayer.PlayOneShot(introbgm);
    
    }

    // Update is called once per frame
    void Update()
    {
    time += Time.deltaTime;
    int currentTime = (int)time;

    if (currentTime == 3) {

            bgmPlayer.Stop();

            bgmPlayer.clip = normalGhostLoop;
            bgmPlayer.loop = true;

            bgmPlayer.Play();

    }

    }


}
