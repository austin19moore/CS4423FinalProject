using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torchHandler : MonoBehaviour
{
    Rigidbody2D rb;
    ParticleSystem ps;
    [SerializeField] LayerMask Player;
    [SerializeField] Character character;

    public bool ifLit;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ps = GetComponent<ParticleSystem>();
        ps.Pause();
        ifLit = false;
    }

   void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, 1f, Player).Length > 0) {

            if (Input.GetKeyDown(KeyCode.F) && !ifLit) {
                
                if (character.HasLighter() == true) {
                    // light torch
                    GetComponent<AudioSource>().Play();
                    ifLit = true;
                    print("Lighting torch");
                    GetComponent<ParticleSystem>().Play();
                }

            }
        }
    }
}
