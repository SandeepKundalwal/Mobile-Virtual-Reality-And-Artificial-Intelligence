using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{	
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) { 
			GameObject bulletObject = Instantiate(bulletPrefab);
			Bullet bullet = bulletObject.GetComponent<Bullet>();
			Vector3 shootingDirection = new Vector3 ( -2,
			Random.Range(0f,+1f),
			Random.Range(-1f,+1f));
			bullet.shootingDirection = shootingDirection.normalized; 
 		}
    }
}
