using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    int cubesGenerated;
    public GameObject Cube;
    // Start is called before the first frame update
    private void Start()
    {
        cubesGenerated = 5;
        for(int i = 0; i < cubesGenerated; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5f, Random.Range(-10, 11));
            Instantiate(Cube, randomSpawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
