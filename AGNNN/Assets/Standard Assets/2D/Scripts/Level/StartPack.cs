using UnityEngine;
using System.Collections;

public class StartPack : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FireController.damageToGive++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        LifeManager.lifeCounter++;
        HpManager.playerHealth = 10;
        PlayerController.moveSpeed = 8;
	}
	
}
