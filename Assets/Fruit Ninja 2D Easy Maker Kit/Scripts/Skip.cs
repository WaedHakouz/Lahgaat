using UnityEngine;
using System.Collections;

public class Skip : MonoBehaviour {


	public GameObject playObject;
	private int skipCount;

	// Use this for initialization
	void Start () {

		skipCount = 0;
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnMouseDown()
	{

		if (skipCount < 3) {

			playObject.GetComponent<playButton>().skip();
			skipCount++;
		}

	}


}
