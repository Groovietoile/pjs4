using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*Script de connexion de l'étudiant*/
public class Connect : MonoBehaviour {
	public InputField login;
	public InputField pass;
	public Text text;
    public static int idJeu;
    public static string logins;
    public static string mdps;

    //public string insertUrl= "http://pjs4.000webhostapp.com/Modele/connect.php";

    void Start(){
		//Boutton de connexion
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

	}
	void TaskOnClick()
	{
		StartCoroutine(SendDataGet());
	}

	IEnumerator SendDataGet(){
        logins = login.text;
        mdps = pass.text;

		/*L'url du script php vérifiant la connexion avec le login et le mdp en paramètres*/
		string url = "http://pjs4.000webhostapp.com/Modele/connect.php?login="+login.text+"&mdp="+pass.text;

		WWW data = new WWW(url);
		yield return data;
		if (data.error!=null) {
			print ("Error " + data.error + url);
		}
		if(data.text !=""){
			/*On récupère 0 : les identifiants sont incorrects*/
            if (data.text.Equals("0", System.StringComparison.OrdinalIgnoreCase))
            {
                text.color = Color.red;
                text.text = "Le login ou le mot passe est incorrect.";

            }
			/*On récupère -1 : l'étudiant existe mais il n'a pas encore avancé dans le jeu*/
            else if (data.text.Equals("-1", System.StringComparison.OrdinalIgnoreCase))
            {
                idJeu = 1;
                SceneManager.LoadScene("scene");

            }
			/*Dans tous les autres cas, l'étudiant a déjà joué au jeu précédemment; on récupère l'id du jeu auquel il s'est arrêté*/
            else { idJeu = int.Parse(data.text); SceneManager.LoadScene("scene"); }
            Debug.Log(idJeu);

			/*On cherche dans la base de données le monde associé à l'id du jeu*/
			url = "http://pjs4.000webhostapp.com/Modele/RecupMonde.php?idMiniJeu=" + idJeu;

			data = new WWW(url);
			yield return data;
			if (data.error != null)
			{
				print("Error " + data.error + url);
			}
			//On affecte à la variable statique monde l'id du monde demandé
			if (data.text != "") {
				int iddumonde = int.Parse(data.text);
				Back.monde = iddumonde;
				BackAccueil.monde = iddumonde;
				Gagnant.monde = iddumonde;



			}


        }
	}

}
