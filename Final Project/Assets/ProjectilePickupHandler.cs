using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePickupHandler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] LayerMask Player;
    [SerializeField] Character character;
    [SerializeField] GunSoundHandler sh;
    [SerializeField] PlayerInputHandler InputHandler;
    GameObject shootText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shootText = GameObject.Find("Canvas");
        shootText.SetActive(false);
    }

   void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, 1f, Player).Length > 0) {
            
            if (Input.GetKeyDown(KeyCode.F)) {
                sh.Play();
                shootText.SetActive(true);
                // pickup
                InputHandler.SetShoot(true);
                // picking up lighter
                print("Lighter picked up");
                Destroy(this.gameObject);
            }
            else {
                shootText.SetActive(false);
            }
        }
    }
}
