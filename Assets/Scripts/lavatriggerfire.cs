using UnityEngine;
using System.Collections;
using System.Linq;

public class lavatriggerfire : MonoBehaviour {
	
	public Transform respawn;
	public GameObject[] invisible;
	public GameObject[] toMute;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if (other.name == "Main Camera"){
			other.transform.position = respawn.position;
			other.audio.Play();
			invisible.ToList().ForEach(x => x.SetActive(false));
			toMute.ToList().ForEach(x => x.audio.Stop());
		}
	}
}
