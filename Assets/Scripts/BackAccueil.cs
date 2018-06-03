using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackAccueil : MonoBehaviour
{
	public Sprite foret;
	public Sprite desert;
	public Sprite montagne;
	public Material feuille;
	public Material sable;
	public Material nuage;
	SpriteRenderer a;

	//variable statique correspondant au monde auquel s'est arrêté l'étudiant
	public static int monde;

	public Text textMonde;

	// Use this for initialization
	void Start()
	{


	}

	// Update is called once per frame
	void Update(){

		//On récupère le composant "image de fond"
		//pour le modifier dynamiquement en fonction
		//du monde ainsi que le nom du monde
		//on change également l'animation
		//définie par un Particle System pour qu'elle
		//s'adapte paysage
		a = GetComponent<SpriteRenderer>();
		if (monde == 1) { a.sprite = foret; GameObject.Find ("Particle System").GetComponent<Renderer>().material = feuille; textMonde.text= "Monde Forêt";}
		else if (monde == 2) { a.sprite = desert; GameObject.Find ("Particle System").GetComponent<Renderer>().material = sable;textMonde.text= "Monde Désert";}
		else if (monde == 3) { a.sprite = montagne; GameObject.Find ("Particle System").GetComponent<Renderer>().material = nuage;textMonde.text= "Monde Montagne";}


	}
}
