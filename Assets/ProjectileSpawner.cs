using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    private readonly string PLAYER_TAG = "Player";
	private Transform playerTransform;

	[SerializeField]
	private float shotDelay = 1f;

	[SerializeField]
	private Transform projectilePrefab;

	private void Awake()
	{
		playerTransform = GameObject.FindGameObjectWithTag(PLAYER_TAG).transform;
		if (playerTransform == null)
		{
			Debug.LogError("Not able to find player in the scene, projectiles will not target correctly");
		}

		if (projectilePrefab == null)
		{
			Debug.LogError("Did not set the projectile prefab");
		}
	}

	private void Start()
	{
		InvokeRepeating("ShootAtPlayer", 0f, shotDelay);
	}

	private void ShootAtPlayer()
	{
		Transform obj = Instantiate(projectilePrefab, transform);
		Projectile projectile = obj.GetComponent<Projectile>();
		projectile.InitProjectile(GetDirectionToPlayer(transform.position));
	}

	private Vector3 GetDirectionToPlayer(Vector3 currentPosition)
	{
		return playerTransform.position - currentPosition;
	}
}
