using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Script qui détecte la validité d'un mot touché par l'oiseau et calcule le score*/
public class Cube : MonoBehaviour {
	
    public bool correct;
    string mot;
    GameObject cube;
    public static Joueur j;
    public static Cube c;
    public int pts=1;
    public int num;

	/*Constructeur des éléments du jeu. Méthode appelé dans le script DuplicationCube*/
	public void init(string mot, bool correct, GameObject cube,int numero)
    {
        this.mot = mot;
        this.correct = correct;
        this.cube = cube;
		TextMesh a = GetComponent<TextMesh>();
		a.text = this.mot;
        this.num = numero;

        //Start();
    }

    public static int getScore()
    {
        return j.score;
    }

	// Use this for initialization
	void Start () {
		
       //gameObject.GetComponent<Renderer>().material.color = Color.yellow;
       /* if (j.difficulte == 1)
        {
            if (correct)
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            else
                gameObject.GetComponent<Renderer>().material.color = Color.red;

        }
        else if (j.difficulte == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }*/
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D()
    {
        //Debug.Log(correct + "    Score : " + j.score);
        if (transform.position.y < -4 && correct )
        {
			Move.renderer.color = new Color(0.99f,0.28f,0.28f,1f);

            if (j.score > 0)
            {
                j.score -= pts;
            }
        }
        else if (correct)
        {
			Move.renderer.color = new Color(1f,1f,1f,1f);
            j.score += pts;
        }
        else  if (transform.position.y > -4.5 && !correct )
        {
			Move.renderer.color = new Color(0.99f,0.28f,0.28f,1f);
            if (j.score > 0) {
                j.score -= pts;
            }
        }

        Debug.Log(correct + "    Score : " + j.score);
        Destroy(gameObject);

        if (num==DuplicationCube.taille-1) {
            j.CalculScore();
        }
    }
}
