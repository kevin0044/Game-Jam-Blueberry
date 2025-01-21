using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Debris")){
            GameOverScreen.GameOver();
        }
    }
}
