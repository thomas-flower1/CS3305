using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
  
   

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(0f, 0f, 10 * Time.deltaTime);
        
        
    }
}
