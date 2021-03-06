using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSystem : MonoBehaviour {

	public Transform explosion; 

	void OnTriggerEnter(Collider Other){
		if (Other.gameObject.tag == "Rocket") {
			Destroy (gameObject);
			Instantiate (explosion, transform.position, transform.rotation);
		}
	}
}
