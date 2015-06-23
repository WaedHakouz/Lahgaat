using UnityEngine;
using System.Collections;

public class myScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		gameObject.active = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseDown () {
		gameObject.active = false;
		//Destroy(gameObject);
		//renderer.enabled = false;
	}
}
