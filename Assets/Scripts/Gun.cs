using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script da Arma
public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject myBullet;
    [SerializeField] private Transform spawnBullet;

    private GameObject newBullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Rotação do disparo da bala, atualizado
            //newBullet = Instantiate(myBullet, spawnBullet.position, Quaternion.identity);
            newBullet = Instantiate(myBullet, spawnBullet.position, spawnBullet.rotation);
            Destroy(newBullet, 10f);
        }
    }
}
