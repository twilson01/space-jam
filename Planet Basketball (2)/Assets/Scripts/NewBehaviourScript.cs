﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public Transform explosion;

	// Use this for initialization
	void Start () {

		explosion.GetComponent<ParticleSystem> ().enableEmission = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		explosion.GetComponent<ParticleSystem> ().enableEmission = true;
		//StartCoroutine(stopExplosion)

		
	}
}
