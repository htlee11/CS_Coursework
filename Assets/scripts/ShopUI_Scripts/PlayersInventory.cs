using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersInventory : MonoBehaviour {
	
	public GameObject ShopStoreObject;
	private ShopStore OtherScriptToAccess;
	private string testStringToGet;
	private int Cost;

	class Item
	{
		public string ItemName;
		public int ItemCost;
		public string ItemType;

		public Item(string _ItemName, int _ItemCost, string _ItemType)
		{
			ItemName = _ItemName;
			ItemCost = _ItemCost;
			ItemType = _ItemType;
		}
	}


	void Start () {
		OtherScriptToAccess = ShopStoreObject.GetComponent<ShopStore> ();
		testStringToGet = OtherScriptToAccess.testString;

		Debug.Log (testStringToGet);
	}

	public void button(){

		Debug.Log ("you pressed tg#he buton");
	}


	public void Additem(){


		Item Sword = new Item("L1Sword", 40, "equipment");
		Item potion = new Item("L1Health", 5, "consumable");
		Item boots = new Item("Boots", 50, "equipment");



	
	}

	void Update () {
		
	}
}
