using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileHandler : MonoBehaviour
{
    GameObject evilCollisionHandler;
    Rigidbody2D rb;
    LayerMask Terrain;

    void Start() {
        evilCollisionHandler = GameObject.FindWithTag("evilViolet");
        rb = GetComponent<Rigidbody2D>();
        Terrain = LayerMask.GetMask("terrain");
    }

    void Update() {
        if (Physics2D.OverlapCircleAll(transform.position, .35f, Terrain).Length > 0) {
                Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {

        if (col.gameObject.tag == "evilViolet") {
            evilCollisionHandler.GetComponent<EvilCollisionHandler>().UpdateBossHP(1);
            Destroy(this.gameObject);
        } else if (col.gameObject.tag == "destroyable") {
            Destroy(this.gameObject);
        }
        else if (col.gameObject.layer.Equals("terrain")) {
            Destroy(this.gameObject);
        } else if (col.gameObject.tag.Equals("counter")) {
            col.GameObject().GetComponent<projectileCounter>().Increment();
            col.GameObject().GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }

}
