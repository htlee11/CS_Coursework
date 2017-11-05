using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersInventory : MonoBehaviour {
	
	public GameObject ShopStoreObject;
	private ShopStore OtherScriptToAccess;
	private string testStringToGet;
	// Use this for initialization
	void Start () {
		
	}

	public void Additem(){
		//testStringToGet = GetComponent<ShopStore> ().testString;

		OtherScriptToAccess = ShopStoreObject.GetComponent<ShopStore> ();
		testStringToGet = OtherScriptToAccess.testString;
		Debug.Log (testStringToGet);
	
	}

	void Update () {
		
	}
}
