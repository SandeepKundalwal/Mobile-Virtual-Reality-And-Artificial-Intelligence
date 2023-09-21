using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 3f;
    public float shootForce = 1500f;
	public Vector3 shootingDirection; 
	public GameObject explosionPrefab; 
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(shootingDirection * shootForce); 
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
    
    void OnCollisionEnter(Collision collision) 
    {
			if(collision.transform.tag == "tagCollision") { 
				GameObject explosionObject = Instantiate(explosionPrefab);
				explosionObject.transform.position = transform.position;	
			}
	}
}
