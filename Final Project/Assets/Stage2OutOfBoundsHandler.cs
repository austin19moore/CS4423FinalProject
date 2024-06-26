using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2OutOfBoundsHandler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] LayerMask Player;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, 8f, Player).Length > 0) {
            print("here");
            SceneManager.LoadScene("Stage2");
        }

    }
}
