using UnityEngine;

public class DebrisDestroyTouch : MonoBehaviour
{

    public Vector3 teleportPosition;

    public string PlayerTag = "Player";

    void OnCollisionEnter(Collision collision) 
    {

     if(collision.gameObject.CompareTag(PlayerTag)){
        
        collision.gameObject.transform.position = teleportPosition;

        Destroy(gameObject);

     } 
     else
     {
        Destroy(gameObject);
     }  
    }
}
