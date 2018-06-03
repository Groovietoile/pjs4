using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Affichage du score*/
public class FinDeJeuScore : MonoBehaviour {

	public TextMesh textScore;
	// Use this for initialization
	void Start () {
		textScore.text = "Score : " + Joueur.scoreglobal.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
	}
}
