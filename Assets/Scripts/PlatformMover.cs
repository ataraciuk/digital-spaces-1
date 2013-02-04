using UnityEngine;
using System.Collections;

public class PlatformMover : MonoBehaviour {

	// Use this for initialization
	Vector3 startPos;
	
	public float speed = 2.0f;
	public float range = 10.0f;
	
	void Start () {
		
		startPos = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		var posfix = this.name.Split('-');
		
		int direction = posfix.Length < 2 ? 1 : (int.Parse(posfix[1]) % 2 == 0 ? -1 : 1);
		
		transform.position = startPos + Vector3.right * ( Mathf.Sin( Time.fixedTime * speed ) * range * direction);
		
	}
}
