using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1CompleteButton : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject[] destroyableObjects;
    [SerializeField] LayerMask Player;
    [SerializeField] torchHandler torch1;
    [SerializeField] torchHandler torch2;
    [SerializeField] torchHandler torch3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        destroyableObjects = GameObject.FindGameObjectsWithTag("destroyable");
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, .5f, Player).Length > 0) {
            if (Input.GetKey(KeyCode.F) && TorchesLit()) {
                GetComponent<AudioSource>().Play();
                DestroyTorches();
            }
        }
    }

    bool TorchesLit() {

        if (torch1.ifLit == false) {
            return false;
        }
        if (torch2.ifLit == false) {
            return false;
        }
        if (torch3.ifLit == false) {
            return false;
        }
        return true;
    }

    void DestroyTorches() {
        for (int i = 0; i < destroyableObjects.Length; i++) {
            // destroyableObjects[i].PlaySound();
            Destroy(destroyableObjects[i]);
        }
    }
}
