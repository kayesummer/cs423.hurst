using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
     private bool isPaused;
     public GameObject pausePanel;
     
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
          {
               if (isPaused)  // game is already paused, resume game
               {
                    ResumeGame();
               }
               else // game isn't paused, so pause it
               {
                    PauseGame();
               }
          }
    }

     public void PauseGame()
     {
          Time.timeScale = 0;
          pausePanel.SetActive(true);
          isPaused = true;
     }

     public void ResumeGame()
     {
          Time.timeScale = 1;
          pausePanel.SetActive(false);
          isPaused = false;
     }
}
