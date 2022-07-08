using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHeadTowardsPlayer : MonoBehaviour
{
	private Transform _playerTransform;
	[SerializeField]
	private float _maxAngleFromForward = 30f;
	[SerializeField]
	private Transform _bodyTransform;

	private void Awake()
	{
		_playerTransform = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).transform;
		if (_bodyTransform == null)
		{
			Debug.LogError("Did not set the monster's body, head rotation will not work");
		}
	}

	private void Update()
	{
		if (CanLookAtTarget())
		{
			transform.LookAt(_playerTransform);
		}
		else
		{
			transform.rotation = Quaternion.identity;
		}
	}

	private bool CanLookAtTarget()
	{
		return Mathf.Abs(Vector3.Angle(_bodyTransform.forward, _playerTransform.position)) <= _maxAngleFromForward;
	}
}
