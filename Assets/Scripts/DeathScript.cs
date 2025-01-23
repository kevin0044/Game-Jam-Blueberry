using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Debris")){
            SceneManager.LoadScene("DeathScreen");
            
        }
    }
}
