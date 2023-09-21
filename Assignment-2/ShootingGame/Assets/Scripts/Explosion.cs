using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour 
{ 
    public float lifeTime = 3f;
    public int amountOfParticles = 10;
    public GameObject[] explosionPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i< amountOfParticles; i++) {
            GameObject particlePrefab = Instantiate (explosionPrefabs[Random.Range(0,explosionPrefabs.Length)]);
            particlePrefab.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        
        if(lifeTime <= 0) 
        { 
			Destroy(gameObject);
		}
        
    }
}
