using UnityEngine;

public class DebrisSpawnerScript : MonoBehaviour
{
    public GameObject[] randomDebris;

    private float nextSpawnTime;
    private int randomIndex;
    void Start()
    {
        SetNextSpawnTime();
        
    }

    
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            randomIndex = Random.Range(0,randomDebris.Length);
            
            SetNextSpawnTime();
            SpawnObject();

        }
    }

    void SpawnObject()
    {
        Instantiate(randomDebris[randomIndex], transform.position, Quaternion.identity);

    }
    
    
    void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + Random.Range(1f,10f);

    }

}
