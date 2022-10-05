using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] weaponsArray;

    private Vector3 spawnPoint;
    private GameObject spawnedWeapon;


    // //

    void Start()
    {
        Debug.Log("Press spacebar to spawn a weapon..");
        spawnPoint = transform.position;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnWeapon();
        }
    }


    private void SpawnWeapon()
    {
        if (spawnedWeapon != null)
        {
            Destroy(spawnedWeapon);
        }

        spawnedWeapon = Instantiate(weaponsArray[Random.Range(0, weaponsArray.Length)], spawnPoint, Quaternion.identity);

        Debug.Log("Your weapon is the " + spawnedWeapon.name + ". Kill 'em all");
    }
}
