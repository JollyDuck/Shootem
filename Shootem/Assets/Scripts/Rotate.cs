using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float rotationSpeed = 100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Rotate(0,0,-rotationSpeed*Input.GetAxis("Horizontal"),Space.World);
		}
}
