using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public Transform bulletOrigin;
    public GameObject bulletprefab;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject newBullet = Instantiate(bulletprefab, bulletOrigin.position, bulletOrigin.rotation);
            newBullet.GetComponent<Bullet>().playerTransform = player;
        }

        
    }
}
