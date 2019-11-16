using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    float currentTime = 0;
    float startingTime = 30;
  
    [SerializeField] Text countdownText; 
    
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        // print(currentTime);
        if (currentTime > 0)
        {

            countdownText.text = "Timer :" + currentTime.ToString();
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }
}
