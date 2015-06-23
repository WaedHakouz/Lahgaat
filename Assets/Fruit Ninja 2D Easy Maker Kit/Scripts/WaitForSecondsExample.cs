using UnityEngine;
using System.Collections;

public class WaitForSecondsExample : MonoBehaviour {
	
	void Start() {
		StartCoroutine(Example());
		print("zzzz");
	}
	
	IEnumerator Example() {
		print("haha");
		yield return new WaitForSeconds(11);
		print("haha");
	}
	
}