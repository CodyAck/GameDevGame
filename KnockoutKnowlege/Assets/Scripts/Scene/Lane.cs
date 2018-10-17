using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour {

	//private String playerLane;
	private playerStatus playerStat;
	//public GameObject player;
	void Awake() {
		playerStat = GameObject.FindObjectOfType<playerStatus>();

	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.name == "Player")
		{
			if (gameObject.name == "LowLane")
			{
				playerStat.UpdateLane(1);
			}
			else if (gameObject.name == "MidLane")
			{
				playerStat.UpdateLane(2);
			}
			else if (gameObject.name == "HighLane")
			{
				playerStat.UpdateLane(3);
			}

		}
	}
	// Update is called once per frame
	void Update () {

	}
}
