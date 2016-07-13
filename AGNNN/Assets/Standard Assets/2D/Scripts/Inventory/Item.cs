using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public string name;
	public enum Type {equip, consumable, misc};
	public Type type;

	public Sprite sprite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseEnter(){
		transform.parent.parent.GetComponent<InventoryController> ().selectedItem = this.transform;
	}
}
