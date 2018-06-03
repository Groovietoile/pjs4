using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DébutNiveau : MonoBehaviour {

	public void LancerPartie()
	{
		SceneManager.LoadScene ("Mini-jeu-Mots");
	}


	public void RetourMonde()
	{
		SceneManager.LoadScene ("");
	}



}




