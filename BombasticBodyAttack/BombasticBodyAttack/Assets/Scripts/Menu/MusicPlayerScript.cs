using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource AudioSource;
    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToInstructions()
    {
        SceneManager.LoadScene("Instructions1");
    }
}
