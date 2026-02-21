using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMiniGame : MonoBehaviour
{
   public GameObject canvas;
   public bool isMiniGame = false;
   public bool inMiniGameArea = false;
   public bool taskCompleted = false;

    void Start()
    {
        canvas.SetActive(isMiniGame);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E) && inMiniGameArea)
        {

            if(isMiniGame)
            {
                isMiniGame = false;

                // enable the mouse
                Cursor.lockState = CursorLockMode.Locked;
                
            } else
            {
                Cursor.lockState = CursorLockMode.None;
                isMiniGame = true;
                
            }

            // TODO need to disable the player movement and camera during this point
        }
        


        canvas.SetActive(isMiniGame);

        if(isMiniGame)
        {
            
        }
    }
}
