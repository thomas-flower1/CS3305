using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 200f;

    private Vector3 velocity;
    public float jumpHeight = 3f;
    public float gravity = -9.81f;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        // for physics updates

        // getting the player input 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // Jump
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        controller.SimpleMove(move * Time.deltaTime * speed);


        
    }


}
