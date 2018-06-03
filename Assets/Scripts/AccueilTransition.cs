using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Script qui génère la scène d'accueil un certain temps
  Après le générique*/
public class AccueilTransition : MonoBehaviour {

	public const float time_limit = 5F;
	private float timer = 0f;

	void Update() {

		this.timer += Time.deltaTime;

		if (this.timer >= time_limit) {
			SceneManager.LoadScene("Connexion", LoadSceneMode.Single);
		}

	}
}