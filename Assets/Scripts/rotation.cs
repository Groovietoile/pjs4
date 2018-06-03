using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	private GameObject pancarte1;
	private GameObject pancarte2;
	private GameObject jouer;
	private Vector3 targetedPosition1;
	private Vector3 targetedPosition2;

	// Use this for initialization
	void Start () {
		pancarte1 = GameObject.Find ("paper_settings");
		pancarte2 = GameObject.Find ("paper_statistics");
		jouer = GameObject.Find("play");
		targetedPosition1 = new Vector3(-12.5f,123f,0f);
		targetedPosition2 = new Vector3 (-12.5f, -159f, 0f);
		pancarte1.transform.position = new Vector3(-650f,123f,0f);
		pancarte2.transform.position = new Vector3(650f,-159f,0f);
	}
	
	// Update is called once per frame
	void Update () {
		pancarte1.transform.position = Vector3.MoveTowards (pancarte1.transform.position, targetedPosition1, 10f);
		pancarte2.transform.position = Vector3.MoveTowards (pancarte2.transform.position, targetedPosition2, 10f);

	}
}
