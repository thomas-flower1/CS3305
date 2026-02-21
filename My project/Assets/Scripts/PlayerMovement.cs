using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 200f;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        // for physics updates

        // getting the player input 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.SimpleMove(move * Time.deltaTime * speed);
        
    }


}
