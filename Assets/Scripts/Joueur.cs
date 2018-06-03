using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Calcul du score du joueur*/
public class Joueur : MonoBehaviour {
    public int score;
	public static int scoreglobal;
    public int difficulte = 1;
	public TextMesh textScore;
	// Use this for initialization
	void Start () {
        Cube.j = this;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		textScore.text = "Score : " + score.ToString ();
	}

    public void CalculScore(){
        int scorej = score;
		scoreglobal = score;
        int nbmot = DuplicationCube.taille;
        int nbmottrue = DuplicationCube.nbmotTrue;

        if (scorej > 0){
            int ratio = (nbmottrue / nbmot) * 100;
            double ratiopourcent = ratio * 0.7;
            int ratioscore = (scorej / nbmot) * 100;

            Debug.Log(scorej + " " + nbmot + " " + nbmottrue);
            if (ratioscore>=ratiopourcent)
            {
                Gagnant.gagne = true;
                SceneManager.LoadScene("FinduJeu", LoadSceneMode.Single);
            }
            else
            {
                Debug.Log("Perdu !");
            }
        }
        else {
            Debug.Log("Perdu !");
        }

        SceneManager.LoadScene("FinduJeu", LoadSceneMode.Single);


    }
}
