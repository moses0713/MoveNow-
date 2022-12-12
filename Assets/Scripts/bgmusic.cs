using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgsound : MonoBehaviour {
	public GameObject obje;  
	GameObject obj=null;  

	void Start () {


		obj = GameObject.FindGameObjectWithTag("sound");  
    	if (obj==null) {  
        	obj = (GameObject)Instantiate(obje); } 
	}

	void Update () {
		
	}
}