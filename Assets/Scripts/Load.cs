using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour {
	
    // Use this for initialization
    void Start () {
        StartCoroutine(SendDataGet());


    }
	
	// Update is called once per frame
	void Update () {

    }

    IEnumerator SendDataGet(){

		string url = "http://pjs4.000webhostapp.com/Modele/connect.php?login=" + Connect.logins + "&mdp=" + Connect.mdps;
		WWW data = new WWW(url);
		yield return data;
		if (data.error != null)
		{
			print("Error " + data.error + url);
		}
		if (data.text != "") {
			if (data.text.Equals("-1", System.StringComparison.OrdinalIgnoreCase))
			{
				Connect.idJeu = 1;
				// SceneManager.LoadScene("scene");

			}
			else { Connect.idJeu = int.Parse(data.text)+1; }
			Debug.Log(Connect.idJeu );

			url = "http://pjs4.000webhostapp.com/Modele/RecupMonde.php?idMiniJeu=" + Connect.idJeu;

			data = new WWW(url);
			yield return data;
			if (data.error != null)
			{
				print("Error " + data.error + url);
			}
			if (data.text != "") {
				int iddumonde = int.Parse(data.text);
				Back.monde = iddumonde;
				BackAccueil.monde = iddumonde;
				Gagnant.monde = iddumonde;



			}

		}
  
             
           

        }

    }

