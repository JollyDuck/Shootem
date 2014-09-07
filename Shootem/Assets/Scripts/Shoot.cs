using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			float mouseX = Input.GetAxis("Mouse X");
			float mouseY = Input.GetAxis("Mouse Y");
			Debug.Log ("MouseX: " + mouseX + " & MouseY: " + mouseY);
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			GameObject g = (GameObject)Instantiate(bullet, transform.position, transform.rotation);

		}
		}


}
