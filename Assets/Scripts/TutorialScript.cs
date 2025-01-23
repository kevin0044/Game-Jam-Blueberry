using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject TutorialText;
    private void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            TutorialText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            TutorialText.SetActive(false);
        }
    }

}
