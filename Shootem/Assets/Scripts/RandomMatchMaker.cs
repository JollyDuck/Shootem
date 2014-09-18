using UnityEngine;
using System.Collections;

public class RandomMatchMaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("1.0");
	
	}

	void OnGUI()
	{
		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
	}

	void OnJoinedLobby(){
		Debug.Log ("Joined Lobby. Trying to Join Random Room...");
		PhotonNetwork.JoinRandomRoom();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnPhotonRandomJoinFailed()
	{
		Debug.Log("Can't join random room! Creating one...");
		PhotonNetwork.CreateRoom(null);

	}

	void OnCreatedRoom(){
		Debug.Log ("Room created");
	}
}
