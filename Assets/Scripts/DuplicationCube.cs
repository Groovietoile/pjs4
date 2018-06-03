using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;

/*Script qui génère les mots qui tombent*/
public class DuplicationCube : MonoBehaviour {
	
	//Url du script php récupérant les réponses à une question
	private string SelectUrl = "http://pjs4.000webhostapp.com/Modele/recupRep.php";

	public SpriteRenderer oiseau;

    //float delay = 1f;
	string[] mots ;
	bool[] corrects;
	bool[] pris;
    public GameObject cube;
    int nombre = 0;
    int cpt = 0;
    public static int taille;
    public static int nbmotTrue;

    // Use this for initialization
    void Start () {
		StartCoroutine(SendDataGet());
		//Debug.Log(mots.Length+"haa");

        
		//initListe();
        InvokeRepeating("Spawn", 1f, 2f);
        //CalculScore();
       
    }
	
	void Update () {

	}


    //Création aléatoire et détection des mots qui tombent
    void Spawn()
    {
       if (nombre >= mots.Length)
        {

            return;
        }

        int a=0;

        if (cpt < pris.Length){
            do
            {
                a = Mathf.CeilToInt(UnityEngine.Random.Range(0, mots.Length));

            } while (pris[a]);
            pris[a] = true;
            cpt++;
        }
        Cube c = cube.GetComponent<Cube>();
		c.init(mots[a], corrects[a], cube,nombre);
		Instantiate(cube, new Vector2(UnityEngine.Random.Range(-1, 1), 3), Quaternion.identity);
        nombre++;
       
    }

   
	/*Récupération des réponses associés à la question en affectant dans un tableau de booléen les bonnes réponses*/
    IEnumerator SendDataGet(){

        WWWForm form = new WWWForm();
        form.AddField("idQuest",Connect.idJeu);
        WWW data = new WWW(SelectUrl,form);
        yield return data;
        if (data.error != null)
        {
            print("Error " + data.error);

        }
        else if (data.text != "") {
            JSONArray parsed = JSON.Parse(data.text).AsArray;
			bool correct=false;
			int i = 0;
			taille = parsed.Count;
			this.mots = new string[taille];
			this.corrects = new bool[taille];
            this.pris = new bool[taille];
            foreach (JSONNode row in parsed){
				this.mots[i]=row["intituleReponse"];
				String row3 = row["bonneReponse"];
				if(row3.Equals("true", StringComparison.OrdinalIgnoreCase)){
					correct = true;
                    nbmotTrue++;
                }
                else if(row3.Equals("false", StringComparison.OrdinalIgnoreCase)){
					correct = false;
				}
				this.corrects[i]=correct;
				i++;
            }
			pris = new bool[mots.Length];
			for ( i = 0; i < mots.Length; ++i)
			{
				pris[i] = false;
			}
        }

    }



}
