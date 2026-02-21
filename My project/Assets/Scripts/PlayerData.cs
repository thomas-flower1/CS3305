using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // track if the key was found
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
       
        if(hit.collider.tag == "Key")
        {
            Destroy(hit.gameObject);
        }
        
    }
}
