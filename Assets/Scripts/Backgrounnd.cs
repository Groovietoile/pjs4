using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Backgrounnd : MonoBehaviour {
	public Sprite foret;
	public Sprite desert;
	public Sprite montagne;
	SpriteRenderer a;
	public float cpt = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		a= GetComponent<SpriteRenderer>();
		cpt += Time.deltaTime;

		if(this.cpt>0 && cpt<2){
			a.sprite = foret;

		}else if(this.cpt>2 && cpt<4){
			a.sprite = desert;

		} else if(this.cpt>4 && cpt<6){
			a.sprite = montagne;

		}else if(this.cpt>6 && cpt<8){
			cpt = 0;
		}
	}
		
		
}
