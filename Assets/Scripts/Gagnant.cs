using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Affichage de l'image de fin de jeu selon si l'étudiant a gagné ou perdu*/
public class Gagnant : MonoBehaviour
{
    public static bool gagne;
    public Sprite foret;
    public Sprite desert;
    public Sprite montagne;
    public Sprite foretP;
    public Sprite desertP;
    public Sprite montagneP;
    public static int monde = 1;
    SpriteRenderer a;
	private int agagne;
    // Use this for initialization
    void Start()
    {
        a = GetComponent<SpriteRenderer>();
		if (gagne) {
			agagne = 1;
			if (monde == 1) {
				a.sprite = foret;
			} else if (monde == 2) {
				a.sprite = desert;
			} else if (monde == 3) {
				a.sprite = montagne;
			}
			StartCoroutine (Gagner());
			StartCoroutine (Jouer());
		} else if (!gagne){
			agagne = 0;
            if (monde == 1) { a.sprite = foretP; }
            else if (monde == 2) { a.sprite = desertP; }
            else if (monde == 3) { a.sprite = montagneP; }
			StartCoroutine (Jouer());
        }

    }

	IEnumerator Gagner(){
		string url = "http://pjs4.000webhostapp.com/Modele/Gagner.php?login="+Connect.logins+"&mdp="+Connect.mdps+"&jeu="+Connect.idJeu;
		WWW data = new WWW(url);
		yield return data;
		if (data.error!=null) {
			print ("Error " + data.error + url);
		}
	

	}

	IEnumerator Jouer(){
		string url = "http://pjs4.000webhostapp.com/Modele/Jouer.php?login="+Connect.logins+"&mdp="+Connect.mdps+"&jeu="+Connect.idJeu+"&score="+Joueur.scoreglobal+"&gagne="+agagne;
		WWW data = new WWW(url);
		yield return data;
		if (data.error!=null) {
			print ("Error " + data.error + url);
		}
		Debug.Log (url);

	}
}
