using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*Gestionnaire d'évènements
Pour le bouton pause dans le jeu*/
public class BtnPause : MonoBehaviour {
	//Variable statique définissant l'état du jeu
	//En pause ou non
    public static bool enPause = false;

	/*Variable correspondant au Canvas
	  désactivé par défaut et qui
	  apparait lorsqu'on appuie sur pause*/
    public GameObject menuPause; 

	void Start () {
        //menuPause.SetActive(false);
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void TaskOnClick()
    {
        enPause = !enPause;
        if (enPause)
        {
            pause();
        }
        else
        {
            resume();
        }
    }

    void pause()
    {
        menuPause.SetActive(true);
        Time.timeScale = 0f;
    }

    void resume()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1f;

    }

}
