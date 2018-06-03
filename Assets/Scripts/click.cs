using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*Gestionnaire d'évènements
  Du bouton de lancement du jeu*/
public class click : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void TaskOnClick(){
		 
		//On charge la scène suivante
		SceneManager.LoadScene("Dialogue-Mots", LoadSceneMode.Single);
	}
}
