using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Bullet : MonoBehaviour
{
	[SerializeField] private float speed_bullet = 100f;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	void FixedUpdate()
	{
		rb.AddForce(transform.forward * speed_bullet);
	}
}
