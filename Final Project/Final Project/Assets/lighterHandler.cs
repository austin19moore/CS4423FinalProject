using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighterHandler : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] LayerMask Player;
    [SerializeField] Character character;
    [SerializeField] LighterSoundHandler sh;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, 1f, Player).Length > 0) {

            if (Input.GetKeyDown(KeyCode.F)) {
                sh.Play();
                sh.HandleText();
                // pickup
                character.SetLighter(true);
                // picking up lighter
                print("Lighter picked up");
                Destroy(this.gameObject);
            }
        }
    }
}
