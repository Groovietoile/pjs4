using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    public Sprite foret;
    public Sprite desert;
    public Sprite montagne;
    SpriteRenderer a;
    public static int monde;
    // Use this for initialization
    void Start()
    {

       
    }

    // Update is called once per frame
	void Update(){
	a = GetComponent<SpriteRenderer>();
		if (monde == 1) { a.sprite = foret; }
		else if (monde == 2) { a.sprite = desert; }
		else if (monde == 3) { a.sprite = montagne;}
    

    }
}
