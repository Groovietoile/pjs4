using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FinDeJeuMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button boutonMenu = GetComponent<Button>();
        boutonMenu.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        SceneManager.LoadScene("scene", LoadSceneMode.Single);
        BtnPause.enPause = false;
        Time.timeScale = 1f;
    }
     
}
