using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2ButtonCompleteHandler : MonoBehaviour
{
    Rigidbody2D rb;
     GameObject[] destroyableObjects;
    [SerializeField] LayerMask Player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        destroyableObjects = GameObject.FindGameObjectsWithTag("destroyable");

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, 1f, Player).Length > 0) {

            if (Input.GetKey(KeyCode.F)) {
                GetComponent<AudioSource>().Play();
                Destroy();
            }
        }
    }

    void Destroy() {
        for (int i = 0; i < destroyableObjects.Length; i++) {
            // destroyableObjects[i].PlaySound();
            Destroy(destroyableObjects[i]);
        }
    }
}
