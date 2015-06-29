using UnityEngine;
using System.Collections;

public class screen : MonoBehaviour {

	private GameObject[] buttons;

	void Start()
	{

	}
	// Use this for initialization
	void Update () {

		//iphone tall
		if (ManageCamera.MaxX () < 7 && ManageCamera.MinX () > 0.8) {
			print ("iphone tall");
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.25F, 0.25F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (3.5F, 3.9F, 0);

			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 8, 0);

			buttons = GameObject.FindGameObjectsWithTag ("Button");


			buttons [0].transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			buttons [1].transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			buttons [2].transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			buttons [0].transform.position = new Vector3 (148.0F, 120F, 0.0F);
			buttons [1].transform.position = new Vector3 (148.0F, 175F, 0.0F);
			buttons [2].transform.position = new Vector3 (148.0F, 230F, 0.0F);

			//for (int x=0 ; x<buttons.Length ; x++)

			//{

			//buttons[x].transform.localScale = new Vector3 ( 0.12F, 0.12F, 0);
			//buttons[x].transform.position += new Vector3 ( -235,((buttons.Length-x)*-60), 0);

			//}

			

		} else 
		if (ManageCamera.MaxX () > 10 && ManageCamera.MaxX () < 13 && ManageCamera.MinX () > -7 && ManageCamera.MinX () <-3  ) {
			print ("iphone wide");
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.35F, 0.35F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (8, 6, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.2F, 1.2F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (1, 6, 0);
			
			buttons = GameObject.FindGameObjectsWithTag ("Button");

			buttons [0].transform.localScale = new Vector3 (0.6F, 0.6F, 0);
			buttons [1].transform.localScale = new Vector3 (0.6F, 0.6F, 0);
			buttons [2].transform.localScale = new Vector3 (0.6F, 0.6F, 0);
			buttons [0].transform.position = new Vector3 (785.0F, 220F, 0.0F);
			buttons [1].transform.position = new Vector3 (785.0F, 310F, 0.0F);
			buttons [2].transform.position = new Vector3 (785.0F, 400F, 0.0F);
			
			
			
		} 
		else 	if (ManageCamera.MaxX () > 7 && ManageCamera.MaxX () < 9 &&  ManageCamera.MinX () > -0.1 && ManageCamera.MinX () <0.8) {
			print ("ipad tall");
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.25F, 0.25F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (3.5F, 3.9F, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 8, 0);
			
			buttons = GameObject.FindGameObjectsWithTag ("Button");
			
			
			buttons [0].transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			buttons [1].transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			buttons [2].transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			buttons [0].transform.position = new Vector3 (210.0F, 120F, 0.0F);
			buttons [1].transform.position = new Vector3 (210.0F, 175F, 0.0F);
			buttons [2].transform.position = new Vector3 (210.0F, 235F, 0.0F);
			
			//for (int x=0 ; x<buttons.Length ; x++)
			
			//{
			
			//buttons[x].transform.localScale = new Vector3 ( 0.12F, 0.12F, 0);
			//buttons[x].transform.position += new Vector3 ( -235,((buttons.Length-x)*-60), 0);
			
			//}
			
			
			
		} else 
		if (ManageCamera.MaxX () > 10 && ManageCamera.MaxX () < 11 &&  ManageCamera.MinX () > -4 && ManageCamera.MinX () < -1) {
			print ("ipad wide");
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.35F, 0.35F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (8, 6, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.2F, 1.2F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (1, 6, 0);
			
			buttons = GameObject.FindGameObjectsWithTag ("Button");
			
			buttons [0].transform.localScale = new Vector3 (0.6F, 0.6F, 0);
			buttons [1].transform.localScale = new Vector3 (0.6F, 0.6F, 0);
			buttons [2].transform.localScale = new Vector3 (0.6F, 0.6F, 0);
			buttons [0].transform.position = new Vector3 (650.0F, 220F, 0.0F);
			buttons [1].transform.position = new Vector3 (650.0F, 310F, 0.0F);
			buttons [2].transform.position = new Vector3 (650.0F, 400F, 0.0F);
			
			
			
		}
		else {

			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (7.6F, 5.9F, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.6F, 1.6F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (-2.5F, 6.5F, 0);

			buttons = GameObject.FindGameObjectsWithTag ("Button");
			buttons [0].transform.localScale = new Vector3 (0.6F , 0.6F , 0) ;
			buttons [1].transform.localScale = new Vector3 (0.6F , 0.6F , 0) ;
			buttons [2].transform.localScale = new Vector3 (0.6F , 0.6F , 0) ;
			buttons [0].transform.position = new Vector3 (902 , 449 , 0) ;
			buttons [1].transform.position = new Vector3 (902 , 319 , 0);
			buttons [2].transform.position = new Vector3 (902 , 199 , 0); 
		}
	}


	

}
