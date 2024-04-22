using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paperHandler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] LayerMask Player;
    [SerializeField] Character character;
    GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text = GameObject.Find("Canvas");
        text.SetActive(false);
    }

   void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, 1.25f, Player).Length > 0) {
                text.SetActive(true);
        } else {
                text.SetActive(false);
        }
    }
}
