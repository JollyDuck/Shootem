using UnityEngine;
using System.Collections;

public class PlanetRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,0.001f,0);
	}


}
