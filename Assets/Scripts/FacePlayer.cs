using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
	private Transform _playerTransform;

	private void Awake()
	{
		_playerTransform = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).transform;
	}

	private void Update()
	{
		transform.LookAt(_playerTransform);
	}
}
