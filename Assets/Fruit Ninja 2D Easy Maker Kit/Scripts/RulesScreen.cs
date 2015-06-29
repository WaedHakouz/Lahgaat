using UnityEngine;
using System.Collections;

public class RulesScreen : MonoBehaviour {

	private GameObject[] buttons;

	void Start()
	{

	}
	// Use this for initialization
	void Update () {

		//iphone tall
		if (ManageCamera.MaxX () < 7 && ManageCamera.MinX () > 0.8) {

			GameObject.FindGameObjectWithTag ("Rules").transform.localScale = new Vector3 (0.55F, 0.55F, 0);
			GameObject.FindGameObjectWithTag ("Rules").transform.position = new Vector3 (3.5F, 5F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 9F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.localScale = new Vector3 (0.2F, 0.2F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.position = new Vector3 (180F,50F, 0);

			

		} else 
		if (ManageCamera.MaxX () > 10 && ManageCamera.MaxX () < 13 && ManageCamera.MinX () > -7 && ManageCamera.MinX () <-3  ) {

			GameObject.FindGameObjectWithTag ("Rules").transform.localScale = new Vector3 (1F, 1F, 0);
			GameObject.FindGameObjectWithTag ("Rules").transform.position = new Vector3 (3F, 4.5F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 9F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.localScale = new Vector3 (0.2F, 0.2F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.position = new Vector3 (100F,50F, 0);
			
		} 
		else 	if (ManageCamera.MaxX () > 7 && ManageCamera.MaxX () < 9 &&  ManageCamera.MinX () > -0.1 && ManageCamera.MinX () <0.8) {

			GameObject.FindGameObjectWithTag ("Rules").transform.localScale = new Vector3 (0.75F, 0.75F, 0);
			GameObject.FindGameObjectWithTag ("Rules").transform.position = new Vector3 (3.5F, 5F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 9F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.localScale = new Vector3 (0.2F, 0.2F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.position = new Vector3 (230F,50F, 0);


			
			
			
		} else 
		if (ManageCamera.MaxX () > 10 && ManageCamera.MaxX () < 11 &&  ManageCamera.MinX () > -4 && ManageCamera.MinX () < -1) {

			GameObject.FindGameObjectWithTag ("Rules").transform.localScale = new Vector3 (1F, 1F, 0);
			GameObject.FindGameObjectWithTag ("Rules").transform.position = new Vector3 (3F, 4.5F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 9F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.localScale = new Vector3 (0.2F, 0.2F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.position = new Vector3 (100F,50F, 0);
			
			
		}
		else {

			GameObject.FindGameObjectWithTag ("Rules").transform.localScale = new Vector3 (1F, 1F, 0);
			GameObject.FindGameObjectWithTag ("Rules").transform.position = new Vector3 (7F, 5F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.6F, 1.6F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (-2.5F, 5F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.localScale = new Vector3 (0.2F, 0.2F, 0);
			GameObject.FindGameObjectWithTag ("Button").transform.position = new Vector3 (1250F,50F, 0);
		}
	}


	

}
