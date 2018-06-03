using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour {

	public Text textBox;
	public static string[] dialogues = {"Bienvenue,","Lisez bien la consigne","le but de l'exercice est de récupérer les mots qui répondent à la question suivante : ",""};
	public int indice = 0;
	public Button btn;
	public string insertUrl="http://pjs4.000webhostapp.com/Modele/recupQuest.php";

	// Use this for initialization
	void Start () {
		//textBox = GetComponent<Text> ();
		btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		StartCoroutine(SendDataGet());
		StartCoroutine (TypePhrase (dialogues[indice]));
		indice++;
	}

	// Update is called once per frame
	void Update () {

	}

	public void TaskOnClick(){
		StopAllCoroutines ();

		if (indice < dialogues.Length) {
			StartCoroutine (TypePhrase (dialogues[indice]));
			indice++;
		} else {
			//btn.SetActive (false);
			LancerPartie ();

		}

	}


	public void LancerPartie()
	{
		SceneManager.LoadScene ("save");
	}


	IEnumerator TypePhrase (string phrase)
	{
		textBox.text = "";
		foreach (char letter in phrase.ToCharArray()) 
		{
			textBox.text += letter;
			yield return null;
		}

	}

	IEnumerator SendDataGet(){
      
		string url = insertUrl + "?idExo="+Connect.idJeu;
		WWW data = new WWW(url);
		yield return data;
		if (data.error!=null) {
			print ("Error " + data.error);
		}
		if(data.text !=""){
			JSONArray parsed = JSON.Parse(data.text).AsArray;
			dialogues[dialogues.Length - 1] ="''"+ parsed[0]["intituleQuestion"]+"''";
		}

	}
}


