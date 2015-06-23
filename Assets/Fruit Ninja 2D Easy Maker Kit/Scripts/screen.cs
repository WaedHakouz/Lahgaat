using UnityEngine;
using System.Collections;

public class screen : MonoBehaviour {

	private GameObject[] buttons;

	void Start()
	{

	}
	// Use this for initialization
	void Update () {

		//print (cam.transform.position);
		if (ManageCamera.MaxX () < 11 && ManageCamera.MaxX () > 6.5) {
			print ("in if1 ");
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.25F, 0.25F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (3.5F, 3.9F, 0);

			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 8, 0);

			buttons = GameObject.FindGameObjectsWithTag ("Button");


			buttons [0].transform.localScale = new Vector3 (0.12F, 0.12F, 0);
			buttons [1].transform.localScale = new Vector3 (0.12F, 0.12F, 0);
			buttons [2].transform.localScale = new Vector3 (0.12F, 0.12F, 0);
			buttons [0].transform.position = new Vector3 (148.0F, 95F, 0.0F);
			buttons [1].transform.position = new Vector3 (148.0F, 150F, 0.0F);
			buttons [2].transform.position = new Vector3 (148.0F, 205F, 0.0F);

			//for (int x=0 ; x<buttons.Length ; x++)

			//{

			//buttons[x].transform.localScale = new Vector3 ( 0.12F, 0.12F, 0);
			//buttons[x].transform.position += new Vector3 ( -235,((buttons.Length-x)*-60), 0);

			//}

			

		} else 
		if (ManageCamera.MaxX () > 7.5 && ManageCamera.MaxX () < 15 && ManageCamera.MinX () < 0.9) {
			//print ("in if2 ");
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.35F, 0.35F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (8, 6, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.2F, 1.2F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (1, 6, 0);
			
			buttons = GameObject.FindGameObjectsWithTag ("Button");

			buttons [0].transform.localScale = new Vector3 (0.12F, 0.12F, 0);
			buttons [1].transform.localScale = new Vector3 (0.12F, 0.12F, 0);
			buttons [2].transform.localScale = new Vector3 (0.12F, 0.12F, 0);
			buttons [0].transform.position = new Vector3 (375.0F, 110F, 0.0F);
			buttons [1].transform.position = new Vector3 (375.0F, 165F, 0.0F);
			buttons [2].transform.position = new Vector3 (375.0F, 220F, 0.0F);
			
			
			
		} else {

			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (7.6F, 5.9F, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.6F, 1.6F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (-2.5F, 6.5F, 0);

			buttons = GameObject.FindGameObjectsWithTag ("Button");
			buttons [0].transform.localScale = new Vector3 (0.3F , 0.3F , 0) ;
			buttons [1].transform.localScale = new Vector3 (0.3F , 0.3F , 0) ;
			buttons [2].transform.localScale = new Vector3 (0.3F , 0.3F , 0) ;
			buttons [0].transform.position = new Vector3 (903 , 449 , 0) ;
			buttons [1].transform.position = new Vector3 (903 , 319 , 0);
			buttons [2].transform.position = new Vector3 (903 , 199 , 0); 
		}
	}


	

}
