using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPrefabScript : MonoBehaviour
{
    public float lifeTime = 3f;
    public float explosionForce = 150f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomDir = new Vector3 (
			Random.Range(-1f,1f),
			Random.Range(-1f,1f),
			Random.Range(-1f,1f) 
        );
        
        float randomForce = Random.Range(0f, explosionForce);
        GetComponent<Rigidbody>().AddForce(randomDir.normalized * randomForce);
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
