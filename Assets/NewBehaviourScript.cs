using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed; 


    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward* speed* Time.deltaTime);
    }
}
