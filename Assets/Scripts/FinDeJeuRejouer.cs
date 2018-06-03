using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*Option pour rejouer*/
public class FinDeJeuRejouer : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Button boutonRejouer = GetComponent<Button>();
        boutonRejouer.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Dialogue-Mots", LoadSceneMode.Single);
    }
}
