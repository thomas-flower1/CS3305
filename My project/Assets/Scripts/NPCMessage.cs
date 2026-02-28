using System;
using System.IO;
using TMPro;
using UnityEngine;

/*
Code to be attached to the collision area of an NPC

Args: the filename of the message that shall be displayed when collision occurs

*/

public class NPCMessage : MonoBehaviour
{

    public string rel_path;
    public TMP_Text text_box;
    private string text;

    public Canvas canvas;
    private bool display_text;
    private int message_index = 0;

    void Start()
    {
        text = File.ReadAllText(rel_path);

        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {

        // looping over the text message 
        if(display_text)
        {
           text_box.text = text[..message_index];
            message_index ++;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<CharacterController>() != null)
        {
            display_text = true;
            canvas.enabled = true;
        }
    }

    // TODO - enable the user to use the mouse to close out of the menu
}
