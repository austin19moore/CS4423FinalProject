using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrabber : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) {
        if (col.GetComponent<Character>() != null) {
            col.transform.parent = this.transform;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.GetComponent<Character>() != null) {
            col.transform.parent = null;
        }
    }
}
