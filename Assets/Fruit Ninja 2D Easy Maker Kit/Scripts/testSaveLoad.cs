using UnityEngine;
using System.Collections;

public class testSaveLoad : MonoBehaviour {

	//public LoadSave test;

	void Start () {


		LoadSave.Save (3);
	
	}
	
	// Update is called once per frame
	void Update () {
	
		LoadSave.Load ();

		print (LoadSave.exist);
		print (LoadSave.ID);
	}
}
