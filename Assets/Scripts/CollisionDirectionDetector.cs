using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDirectionDetector : MonoBehaviour
{

	private void OnCollisionEnter(Collision collision)
	{
		DetectDirection(collision.transform);
	}

	public void DetectDirection(Transform incomingTransform)
	{
		Vector3 directionTowardsObject = (transform.position - incomingTransform.position).normalized;
		
		float dotProduct = Vector3.Dot(Vector3.forward, directionTowardsObject);
		if (dotProduct < 0)
		{
			Debug.Log("Was hit from front!");
		}

		if (dotProduct > 0)
		{
			Debug.Log("Was hit from behind!");
		}

		dotProduct = Vector3.Dot(Vector3.right, directionTowardsObject);
		if (dotProduct < 0)
		{
			Debug.Log("Was hit from the right!");
		}

		if (dotProduct > 0)
		{
			Debug.Log("Was hit from the left!");
		}
	}
}
