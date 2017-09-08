using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public List<AxleInfo> axleInfos;
	public float maxMotorTorque;
	public float maxSteeringAngle;

	public void ApplyLocalPositionToVisual(WheelCollider collider)
	{
		if (collider.transform.childCount == 0) {
			return;
		}

		Transform visualWheel = collider.transform.GetChild (0);

		Vector3 pos;
		Quaternion q;
		collider.GetWorldPose (out pos, out q);

		visualWheel.transform.position=pos;
		visualWheel.transform.rotation=q*Quaternion.Euler(0f,0f,90f);
		
	}
	public void FixedUpdate(){
	
		float motor = maxMotorTorque * Input.GetAxis ("Vertical");
		float steering = maxSteeringAngle * Input.GetAxis ("Horizontal");
	
		foreach (AxleInfo axleInfo in axleInfos) {
			if (axleInfo.steering) {

				axleInfo.leftWheel.steerAngle = steering;
				axleInfo.rightWheel.steerAngle = steering;
			}
			if (axleInfo.motor) {
				axleInfo.leftWheel.motorTorque = motor;
				axleInfo.rightWheel.motorTorque = motor;
			}
			ApplyLocalPositionToVisual (axleInfo.leftWheel);
			ApplyLocalPositionToVisual (axleInfo.rightWheel);
		}
	}
	[System.Serializable]
	public class AxleInfo
	{
		public WheelCollider leftWheel;
		public WheelCollider rightWheel;
		public bool motor;
		public bool steering;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		


	}
}
