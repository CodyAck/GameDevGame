using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStatus : MonoBehaviour {
	private int minHealth,currentHealth, HitDamage, Lives;
	public int maxHealth = 50;
	private int LaneNum;
	public Slider slider;
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	public void UpdateLane(int n)
	{
		LaneNum = n;
		Debug.Log(LaneNum);
	}
	public void UpdateHealth(int n)
	{
		currentHealth = currentHealth - n;
		slider.value = currentHealth;
	}
	public int returnHealth()
	{
		return currentHealth;
	}
	void Update () {

	}
}
