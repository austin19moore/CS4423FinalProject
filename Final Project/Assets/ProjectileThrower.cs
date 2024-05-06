using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileThrower : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Character player;
    
    public void Launch(Vector3 targetPos) {
        GameObject newProjectile = Instantiate(projectilePrefab, player.transform.position, Quaternion.identity);
        // newProjectile.transform.rotation = Quaternion.LookRotation(transform.forward, targetPos - transform.position);
        newProjectile.GetComponent<Rigidbody2D>().velocity = transform.up * 2.5f;
    }
}
