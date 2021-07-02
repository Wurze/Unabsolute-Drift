using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioSource cassetSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void QuitGame()
    {
        Debug.Log("Quit!!");
        Application.Quit();
    }

    public void playSoundEffect()
    {
        cassetSound.Play();
    }

    public void NewGame()
    {
 
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
