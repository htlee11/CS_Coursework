using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mons : MonoBehaviour {
	public int moneys_o = 9990;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		moneys_o += 1;
	}


}
