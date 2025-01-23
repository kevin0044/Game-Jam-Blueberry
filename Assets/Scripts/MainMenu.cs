using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
void Update() {
            
            if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }



}
