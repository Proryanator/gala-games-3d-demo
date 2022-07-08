using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 _direction;
    private float _startTime;
    private Rigidbody _rigidBody;

    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private float _projectileLifetime = 10f;

	private void Awake()
	{
        _rigidBody = transform.GetComponent<Rigidbody>();
	}

	public void InitProjectile(Vector3 direction)
    {
        _direction= direction;
        _startTime = Time.time;
    }

    private void Update()
	{
        if (Time.time - _startTime >= _projectileLifetime)
        {
            Destroy(gameObject);
        }

        _rigidBody.AddForce(_direction.normalized * _speed);
    }

	private void OnCollisionEnter(Collision collision)
	{
        Destroy(gameObject);
    }
}
