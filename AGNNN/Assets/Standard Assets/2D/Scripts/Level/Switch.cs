using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour
{

    public bool SwitchOn;
    public GameObject SwitchItem;
    public GameObject SwitchItem2;
    public AudioSource SwitchSound;
    // Use this for initialization
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

    }
   
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.W) && SwitchOn == true)
            {

                SwitchOn = !SwitchOn;
                SwitchItem.SetActive(false);
                SwitchItem2.SetActive(false);
                SwitchSound.Play();
                Debug.Log("Switch ahora es FALSO");
            }
            if (other.gameObject.name == "Player")
            {
                if (Input.GetKeyUp(KeyCode.S) && SwitchOn == false)
                {

                    SwitchOn = true;
                    SwitchItem.SetActive(true);
                    SwitchItem2.SetActive(true);
                    Debug.Log("Switch ahora es FALSO");
                    SwitchSound.Play();
                }
            }


        }
    }
          
        
        }


    
