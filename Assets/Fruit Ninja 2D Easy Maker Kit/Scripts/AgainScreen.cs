using UnityEngine;
using System.Collections;

public class AgainScreen : MonoBehaviour {

	private GameObject[] button;

	void Update () {
		
		//iphone tall
		if (ManageCamera.MaxX () < 7 && ManageCamera.MinX () > 0.8) {
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.25F, 0.25F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (3.5F, 3.9F, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 8, 0);
			
			button = GameObject.FindGameObjectsWithTag ("Button");
			
			

			button[1].transform.localScale = new Vector3 (1F, 1F, 0);

			button[1].transform.position = new Vector3 (160.0F, 230F, 0.0F);

			
			button[0].transform.localScale = new Vector3 (1F, 1F, 0);
			
			button[0].transform.position = new Vector3 (160.0F, 130F, 0.0F);


			//for (int x=0 ; x<buttons.Length ; x++)
			
			//{
			
			//buttons[x].transform.localScale = new Vector3 ( 0.12F, 0.12F, 0);
			//buttons[x].transform.position += new Vector3 ( -235,((buttons.Length-x)*-60), 0);
			
			//}
			
			
			
		} else //iphone wide
		if (ManageCamera.MaxX () > 10 && ManageCamera.MaxX () < 13 && ManageCamera.MinX () > -7 && ManageCamera.MinX () < -3) {
			//print ("in if2 ");
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.35F, 0.35F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (8, 6, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.2F, 1.2F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (1, 6, 0);
			
			button = GameObject.FindGameObjectsWithTag ("Button");
			

			button[1].transform.localScale = new Vector3 (0.8F, 0.8F, 0);
			button[1].transform.position = new Vector3 (790.0F, 380F, 0.0F);
			button[0].transform.localScale = new Vector3 (0.8F, 0.8F, 0);
			button[0].transform.position = new Vector3 (790.0F, 260F, 0.0F);
			
			
		} else 
		
		 if (ManageCamera.MaxX () > 7 && ManageCamera.MaxX () < 9 && ManageCamera.MinX () > -0.1 && ManageCamera.MinX () < 0.8) {
			//ipad Tall
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.25F, 0.25F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (3.5F, 3.9F, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1F, 1F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (3.5F, 8.5F, 0);
			
			button = GameObject.FindGameObjectsWithTag ("Button");
			
			
			
			button[1].transform.localScale = new Vector3 (1F, 1F, 0);
			
			button[1].transform.position = new Vector3 (265.0F, 270F, 0.0F);

			button[0].transform.localScale = new Vector3 (1F, 1F, 0);
			
			button[0].transform.position = new Vector3 (265.0F, 175F, 0.0F);


		} 
			//ipad Wide
		else if (ManageCamera.MaxX () > 10 && ManageCamera.MaxX () < 11 && ManageCamera.MinX () > -4 && ManageCamera.MinX () < -1) {

			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.35F, 0.35F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (8, 6, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.2F, 1.2F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (1, 6, 0);
			
			button = GameObject.FindGameObjectsWithTag ("Button");
			
			
			button[1].transform.localScale = new Vector3 (0.8F, 0.8F, 0);
			button[1].transform.position = new Vector3 (830.0F, 460F, 0.0F);

			button[0].transform.localScale = new Vector3 (0.8F, 0.8F, 0);
			button[0].transform.position = new Vector3 (830.0F, 340F, 0.0F);

		}
		
		else{
			
			GameObject.FindGameObjectWithTag ("MenuBack").transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			GameObject.FindGameObjectWithTag ("MenuBack").transform.position = new Vector3 (7.6F, 5.9F, 0);
			
			GameObject.FindGameObjectWithTag ("logo").transform.localScale = new Vector3 (1.6F, 1.6F, 0);
			GameObject.FindGameObjectWithTag ("logo").transform.position = new Vector3 (-2.5F, 6.5F, 0);
			
			button = GameObject.FindGameObjectsWithTag ("Button");
			button[1].transform.localScale = new Vector3 (1F , 1F , 0) ;
			button[1].transform.position = new Vector3 (920 , 375 , 0);
			button[0].transform.localScale = new Vector3 (1F , 1F , 0) ;
			button[0].transform.position = new Vector3 (920 , 190 , 0);
		}
	}
	
	

}
