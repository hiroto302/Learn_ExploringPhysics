using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{

    public GameObject projectilePrefab;
    public Transform projectileSpawnLocation;
    public float launchPower;

    public void Launch()
    {
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnLocation.position, projectileSpawnLocation.rotation);
        Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();
        projectileRigidbody.AddForce(projectileSpawnLocation.up * launchPower);
    }
}
