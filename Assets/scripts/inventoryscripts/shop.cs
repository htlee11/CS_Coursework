using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item {
	public string Name;
	public double Price;
	public int Quantity;

	public Item(string name, double price, int quantity) {
		Name = name; Price = price; Quantity = quantity;
	}

	public void Print() {
		Console.WriteLine(Quantity + " " + Name + "(s) @ $" + Price);
	}
}

public class Shop : MonoBehaviour {


	public List<Item> Inventory = new List<Item>();

	// Use this for initialization
	void Start () {
		Inventory.Add (new Item ("sword", 50, 10));
		Inventory.Add (new Item ("shield", 60, 10));
		Inventory.Add (new Item ("potion", 5, 10));



	}




	// Update is called once per frame
	void Update () {
		
	}
}
