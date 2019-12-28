using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinIsAlive : MonoBehaviour {

	public bool isAlive = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!isAlive){
			Destroy(gameObject);
		}
	}
}
