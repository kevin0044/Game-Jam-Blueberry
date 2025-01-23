using UnityEngine;

public class EndingScript : MonoBehaviour
{
    public GameObject EndingText;

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Player"){
            EndingText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Player"){
            EndingText.SetActive(false);
        }
    }
}
