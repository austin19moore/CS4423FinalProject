using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInputHandler : MonoBehaviour
{

    [SerializeField] Character player;
    [SerializeField] ProjectileThrower projectileThrower;
    [SerializeField] bool canShootProjectiles = false;

    internal void SetShoot(bool v)
    {
        canShootProjectiles = v;
    }

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
            string currScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currScene);
        }
        if (Input.GetKeyDown(KeyCode.E) && canShootProjectiles) {
            projectileThrower.Launch(Input.mousePosition);
        }

        player.Move(input);
        

    }

}
