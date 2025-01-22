using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject Player;
    public void GameOver()
    {
        SceneManager.LoadScene("DeathScreen");
    }
}
