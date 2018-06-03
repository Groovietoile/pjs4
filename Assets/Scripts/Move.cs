using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Script de déplacement de l'oiseau dans le mini-jeu*/
public class Move : MonoBehaviour {

	public static SpriteRenderer renderer;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        renderer = gameObject.GetComponent<SpriteRenderer>();
		//renderer.color = new Color32(254,73,73,0);
        int sign = 0;
        float x = transform.position.x;
            float y = transform.position.y;
			float z = transform.position.z;
        if (Input.GetMouseButton(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Si l'utilisateur touche la partie gauche de l'écran
                if (hit.transform.position.x < 0)
                {
                    renderer.flipX = false;
                    sign = -1;
                }
				//Si l'utilisateur touche la partie droite de l'écran
                else if (hit.transform.position.x > 0)
                {
                    renderer.flipX = true;
                    sign = 1;
                }

                
                if (x < -2.1)
                    transform.position = new Vector3(-2.1f, y, z);
                if (x > 2.1)
                    transform.position = new Vector3(2.1f, y, z);
				transform.position += new Vector3(sign*0.1f, 0, 0);
            }
        }
        
            //if (x < -2.5 || x > 2.5)
            //transform.position -= new Vector3(Input.GetAxis("Horizontal") * 0.2f, 0, 0);
       // }
    }
    
}