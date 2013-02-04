using UnityEngine;
using System.Collections;

public class showNext : MonoBehaviour {
	
	public GameObject next;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if (other.name == "Main Camera"){
			next.SetActive(true);
		}
	}
}
