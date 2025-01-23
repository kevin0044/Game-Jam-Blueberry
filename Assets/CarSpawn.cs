using System.Collections;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject Vehicle;
    [SerializeField] private Transform spawnPos;
    [SerializeField] private float minSeparationTime;
    [SerializeField] private float maxSeparationTime;

    private void Start(){
        StartCoroutine(SpawnVehicle());
    }


    // Update is called once per frame
    private IEnumerator SpawnVehicle()
    {
        yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));
        Instantiate(Vehicle, spawnPos.position, Quaternion.identity);
    }
}
