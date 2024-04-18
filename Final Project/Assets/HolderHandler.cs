using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderHandler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] LayerMask Projectile;
    [SerializeField] DestructionSoundHandler soundHandler;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, 1f, Projectile).Length > 0) {
            soundHandler.Play();
            Destroy(this.gameObject);
        }

    }
}
