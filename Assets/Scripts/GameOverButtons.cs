using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverButtons : MonoBehaviour
{
        void Update() {
            
            if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        public void RestartButton(){
        SceneManager.LoadScene("Game");
        Debug.Log("Game");
    }

    public void MainMenuButton(){
        SceneManager.LoadScene("MainMenu");
        Debug.Log("MainMenu");
    }
}
