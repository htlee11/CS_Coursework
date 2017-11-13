using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Appear : MonoBehaviour 
{
	public GameObject Panel;

	void OnTriggerEnter2D(Collider2D col)
    {
		Panel.gameObject.SetActive (true);
		Debug.Log ("you hit the box collider");

			
	}

	void OnTriggerExit2D(Collider2D col){
        
		Panel.gameObject.SetActive (false);
	}


}
