using UnityEngine;

public class CameraScript : MonoBehaviour {

	public Transform target;
	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	void FixedUpdate ()
	{
        target = GameObject.FindGameObjectWithTag("inTurn").transform;
		

		transform.LookAt(target);
	}

}
