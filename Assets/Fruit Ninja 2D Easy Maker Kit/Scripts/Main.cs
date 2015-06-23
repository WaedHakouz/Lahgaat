using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		LoadSave.Load ();
		if (LoadSave.exist == true)
			Application.LoadLevel ("original");
		else 
			print ("first time login");
	}
	

}
