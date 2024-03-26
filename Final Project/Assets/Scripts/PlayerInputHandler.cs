using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInputHandler : MonoBehaviour
{

    [SerializeField] Character player;


    void Update() {

        Vector3 input = Vector3.zero;

        if (Input.GetKey(KeyCode.A)) {
            // left
            input.x = -1;
        } 
        if (Input.GetKey(KeyCode.D)) {
            // right
            input.x = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            // jump
            player.Jump();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            // menu
            SceneManager.LoadScene("Tutorial");
        }

        if (input != Vector3.zero) {
            player.Move(input);
        }

    }

}
