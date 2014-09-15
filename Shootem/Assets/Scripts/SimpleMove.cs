using UnityEngine;
using System.Collections;

public class SimpleMove : MonoBehaviour {
	Rigidbody shipRigidBody;
	public float forwardSpeed = 1;
	public float rotateSpeed = 1;
	// Use this for initialization
	void Start () {
		shipRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		if(Input.GetAxis("Vertical") != 0){
			
			shipRigidBody.AddRelativeForce(new Vector3(0,0,forwardSpeed*Input.GetAxis("Vertical")));
			
		}
		if(Input.GetAxis ("Horizontal") != 0){
			shipRigidBody.AddTorque(Vector3.up * Input.GetAxis ("Horizontal")* rotateSpeed);
			//transform.Rotate(Vector3.up * Time.deltaTime *Input.GetAxis ("Horizontal") * rotateSpeed );
		}
		
		if(shipRigidBody.velocity.magnitude>10) Debug.Log ("Ship's going real fast!");
	}

}
