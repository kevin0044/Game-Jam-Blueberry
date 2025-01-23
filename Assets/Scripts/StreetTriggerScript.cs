using UnityEngine;

public class StreetTriggerScript : MonoBehaviour
{
    public GameObject StreetText;

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Player"){
            StreetText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Player"){
            StreetText.SetActive(false);
        }
    }
}
