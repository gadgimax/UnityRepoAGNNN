using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
        public Transform firePoint;
        public GameObject FireBreath;
        public bool facingLeft;
        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            
           if (Input.GetKeyDown(KeyCode.A))   //Activa el disparo en velocidad negativa, es decir a la izquierda. 
            {
                facingLeft = true;
            }

           if (Input.GetKeyDown(KeyCode.D))
            {
                facingLeft = false;   //Desactiva el disparo en negativo, es decir ahora dispara a la derecha
                
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(FireBreath, firePoint.position, firePoint.rotation);
            }

            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
