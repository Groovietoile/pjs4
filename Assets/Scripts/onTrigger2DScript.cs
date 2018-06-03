using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigger2DScript : MonoBehaviour {

	void OnTriggerEnter2D()
    {
        Debug.Log("Trigger touched");
    }

    void OnTriggerStay2D()
    {
        Debug.Log("Trigger touching");
    }

    void OnTriggerExit2D()
    {
        Debug.Log("Exit Trigger");
    }
}
