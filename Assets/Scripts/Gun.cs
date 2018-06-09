﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject myBullet;
    [SerializeField] private Transform spawnBullet;

    private GameObject newBullet;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //newBullet = Instantiate(myBullet, spawnBullet.position, Quaternion.identity);
            newBullet = Instantiate(myBullet, spawnBullet.position, spawnBullet.rotation);
            Destroy(newBullet, 5f);
        }
    }
}
