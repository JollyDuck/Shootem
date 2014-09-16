using UnityEngine;
using System.Collections;

public class HelmMove : MonoBehaviour {
	public float[] speeds = {-20, -10, 0, 25, 50, 75, 100};
	public float currentSpeed = 0f;
	public float targetSpeed = 0f;
	public float acceleration = 5f;
	public float rotationSpeed = 0.05f;
	public int rudderPosition = 0;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeSpeed(float f){
		targetSpeed = speeds[(int)f];
	}

	public void changeRotation(float f){
		rudderPosition = (int)f;
	}
	// Physics update
	void FixedUpdate() {
		updateSpeed();
		updateRotation();

	}

	private void updateSpeed(){
		if(currentSpeed< targetSpeed){
			rb.AddRelativeForce(new Vector3(0,0,acceleration));
		}
		else if(currentSpeed>targetSpeed){
			rb.AddRelativeForce(new Vector3(0,0,-acceleration));
		}

		currentSpeed = rb.velocity.z;
	}

	private void updateRotation(){
		rb.AddTorque(Vector3.up*rudderPosition*rotationSpeed);



	}

}
