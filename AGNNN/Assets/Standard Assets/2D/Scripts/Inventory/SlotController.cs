using UnityEngine;
using System.Collections;

public class SlotController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		transform.parent.GetComponent<InventoryController> ().selectedSlot = this.transform;
	}

	void OnMouseExit(){
		transform.parent.GetComponent<InventoryController> ().selectedSlot = null;
	}
}
