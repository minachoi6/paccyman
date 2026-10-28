using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public AudioSource sfxPlayer;
    public AudioClip open;

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadLvl1() {
        SceneManager.LoadScene(1);
        sfxPlayer.PlayOneShot(open);
    }
    public void ExitScene() {
        SceneManager.LoadScene(0);
    }
    void highscore()
    {
        
    }
}
