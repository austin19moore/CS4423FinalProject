using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateHandler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] LayerMask Player;
    bool destroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   void Update()
    {
        if (!destroyed && Physics2D.OverlapCircleAll(transform.position, .35f, Player).Length > 0) {
                GetComponent<AudioSource>().Play();
                Destroy(GameObject.Find("holder"));
                destroyed = true;
        }
    }
}
