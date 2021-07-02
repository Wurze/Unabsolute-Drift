using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{


    public float currentTime = 0f;
    public float timeLeft = 3.0f;
    public Text startText;
    public Text scoreText;
  
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;

    }





    // Update is called once per frame
    void Update()
    {
        
        currentTime -= Time.unscaledDeltaTime;
        startText.text = (currentTime).ToString("0");
        if (currentTime < 1)
        {

            startText.text = "RIDE!";
           


        }

        if(currentTime <= 0)
        {
            Time.timeScale = 1f;
            RemoveText();
        }


        
    }

 
    void RemoveText()
    {
        startText.gameObject.SetActive(false);
    }
}
