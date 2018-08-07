using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour {

    [SerializeField]
    GameObject [] lights;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow)) {
            foreach (GameObject name in lights)
                name.GetComponent<Light>().enabled = true;                     
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            foreach (GameObject name in lights)
                name.GetComponent<Light>().enabled = false;
        }


    }
}
