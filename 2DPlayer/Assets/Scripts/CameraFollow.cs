using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.one;
	
	void Start () {
	
	}

	void LateUpdate () {
	
		Vector3 targetPosition = player.TransformPoint(new Vector3(0, 0, -10));
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

	}
}
