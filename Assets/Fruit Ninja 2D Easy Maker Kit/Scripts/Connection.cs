using UnityEngine;
using System.Collections;

public class Connection : MonoBehaviour {

	void Start () {
		string url = "http://example.com/script.php?var1=value2&amp;var2=value2";
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));
	}
	
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		
		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.data);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
}
