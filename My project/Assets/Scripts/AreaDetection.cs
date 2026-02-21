using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.WSA;

public class AreaDetection : MonoBehaviour
{

    public bool inArea = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float start_press;

    private float total_time = 3f;

    // TODO add a thing to instantiate all the game objects on start

    public GameObject poster;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inArea = true;
            Debug.Log("In area");

            // functionality for mini game
            if(tag == "Mini Game")
            {
                PlayerMiniGame player = other.GetComponent<PlayerMiniGame>();
                player.inMiniGameArea = true;
             
            }

            
           
    
            // set a variable to true,
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            inArea = false;
            PlayerMiniGame player = other.GetComponent<PlayerMiniGame>();
            player.inMiniGameArea = false;

        }
    }

    void Update()
    {
        if(inArea && Input.GetKey(KeyCode.E))
        {
            if(start_press == 0)
            {
                start_press = Time.time;
            }
           
            float held_time = Time.time - start_press;
            Debug.Log(held_time);

            if(held_time > total_time)
            {
                Destroy(poster);
            }

            // TODO when the time exceeds the set time variable - we need to delete the correspodning poster

          
        } else
        {
            // reset the time 
            start_press = 0f;
        }
    }
}
