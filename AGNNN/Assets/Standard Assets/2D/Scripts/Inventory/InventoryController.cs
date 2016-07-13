using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour {

	public Transform selectedItem, selectedSlot, originalSlot; 

	public GameObject slotPrefab, itemPrefab;
	public Vector2 invetorySize = new Vector2(4,6);
	public float slotSize;
	public Vector2 windowSize;

	// Use this for initialization
	void Start () {
		for (int x = 1; x <= invetorySize.x; x++) {
			for(int y = 1; y <= invetorySize.y; y ++){
				GameObject slot = Instantiate(slotPrefab) as GameObject;
				slot.transform.parent = this.transform;
				slot.name = "slot_"+x+"_"+y;
				slot.GetComponent<RectTransform>().anchoredPosition = new Vector3(windowSize.x/(invetorySize.x+1)*x, windowSize.y / (invetorySize.y+1) * -y);

				if((x + (y - 1)*4) <= GameDB.itemList.Count){
					GameObject item = Instantiate(itemPrefab) as GameObject;
					item.transform.parent = slot.transform;
					item.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
					Item i = item.GetComponent<Item>();

					//ITEM COMPONENT VARIABLES
					i.name = GameDB.itemList[(x + (y - 1)*4) - 1].name;
					i.type = GameDB.itemList[(x + (y - 1)*4) - 1].type;
					i.sprite = GameDB.itemList[(x + (y - 1)*4) - 1].sprite;

					item.name = i.name;
					item.GetComponent<Image>().sprite = i.sprite;


				}

			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && selectedItem != null){
			originalSlot = selectedItem.parent;
			selectedItem.GetComponent<Collider>().enabled = false;
		}

		if (Input.GetMouseButton (0) && selectedItem != null) {
			selectedItem.position = Input.mousePosition;
		}
		else if(Input.GetMouseButtonUp(0) && selectedItem != null){
			if(selectedSlot == null) selectedItem.parent = originalSlot;
			else{
				selectedItem.parent = selectedSlot;
			}
			selectedItem.localPosition = Vector3.zero;
			selectedItem.GetComponent<Collider>().enabled = true;
		}
	}
}
