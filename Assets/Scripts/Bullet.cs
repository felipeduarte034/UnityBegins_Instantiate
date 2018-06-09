using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

//Script da bala
public class Bullet : MonoBehaviour
{
	[SerializeField] private float speed_bullet = 100f;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void FixedUpdate()
	{
		rb.AddForce(transform.forward * speed_bullet);
	}
}

//Eu estive aqui
//alterações feitas por Felipe
//ensinando o comando 'pull'
