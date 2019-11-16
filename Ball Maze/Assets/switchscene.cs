using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene : MonoBehaviour
{
   public int index=0;
   //public string levelname;
   
    void OnTriggerEnter(Collider other)
    {
	
        if (index<3)
        {
            	index++;
		
		SceneManager.LoadScene(index);
        }

	
           // SceneManager.LoadScene(levelname);
        
    }


   
}
