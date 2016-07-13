using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameDB : MonoBehaviour {

	public Sprite[] sprites;

	public static List<Item> itemList = new List<Item>();

	// Use this for initialization
	void Start () {

		//ITEM CREATION
		Item i0 = new Item();
		i0.name = "Golden Sword";
		i0.type = Item.Type.equip;
		i0.sprite = sprites[0];
		itemList.Add(i0);

		//ITEM CREATION
		Item i1 = new Item();
		i1.name = "Health Potion";
		i1.type = Item.Type.consumable;
		i1.sprite = sprites[1];
		itemList.Add(i1);

		//ITEM CREATION
		Item i2 = new Item();
		i2.name = "Rejuvenation Potion";
		i2.type = Item.Type.consumable;
		i2.sprite = sprites[2];
		itemList.Add(i2);

		//ITEM CREATION
		Item i3 = new Item();
		i3.name = "Bow";
		i3.type = Item.Type.equip;
		i3.sprite = sprites[3];
		itemList.Add(i3);

		//ITEM CREATION
		Item i4 = new Item();
		i4.name = "Iron Sword";
		i4.type = Item.Type.equip;
		i4.sprite = sprites[4];
		itemList.Add(i4);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
