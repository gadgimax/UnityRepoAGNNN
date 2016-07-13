using UnityEngine;
using System.Collections;

public class SwitchPlate : MonoBehaviour {

    public bool SwitchOn;
    public GameObject SwitchItemout;
    public GameObject SwitchItemin;
    public AudioSource SwitchSound;
    // Use this for initialization
    void Start()
    {
        SwitchOn = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && SwitchOn == true)
        {
          
                SwitchOn = !SwitchOn;
                SwitchItemout.SetActive(false);
                SwitchItemin.SetActive(true);
                SwitchSound.Play();
                Debug.Log("Switch ahora es FALSO");
            }
            


        }
    }



