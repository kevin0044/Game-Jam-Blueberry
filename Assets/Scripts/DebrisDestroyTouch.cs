using UnityEngine;

public class DebrisDestroyTouch : MonoBehaviour
{
    public Vector3 teleportPosition;
    public string PlayerTag = "Player";
   public GameOverScreen gameOverScreen;
    void OnCollisionEnter(Collision collision) 
     {
        Destroy(gameObject);
     }  
    
}

