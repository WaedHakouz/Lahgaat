using UnityEngine;
using System.Collections;

public class GameScreen : MonoBehaviour {

	private GameObject[] chars , obs;


	

	void Update () {


		if (ManageCamera.MaxX () < 7 && ManageCamera.MinX () > 0.8) {

			//GameObject.FindGameObjectWithTag ("Score").transform.localScale = new Vector3 (0.01F, 0.01F, 0);
			GameObject.FindGameObjectWithTag ("Skip").transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			GameObject.FindGameObjectWithTag ("Skip").transform.position = new Vector3 (5.5F, 2.3F, 0);
			GameObject.FindGameObjectWithTag ("bottom").transform.localScale = new Vector3 (0.7F, 0.7F, 0);
			GameObject.FindGameObjectWithTag ("bottom").transform.position = new Vector3 (3.5F, 1.45F, 0);
			GameObject.FindGameObjectWithTag ("Score").transform.localScale = new Vector3 (0.55F, 0.55F, 0);
			GameObject.FindGameObjectWithTag ("Score").transform.position = new Vector3 (4.3F, 1.3F, 0);
			GameObject.FindGameObjectWithTag ("recWord").GetComponent<GUIText> ().fontSize = 35;
			GameObject.FindGameObjectWithTag ("recWord").transform.position = new Vector3 (0.35F, 0.05F, 0);
			GameObject.FindGameObjectWithTag ("Points").GetComponent<GUIText> ().fontSize = 35;
			GameObject.FindGameObjectWithTag ("Points").transform.position = new Vector3 (0.15F, 0.03F, 0);
			GameObject.FindGameObjectWithTag ("Lives").transform.localScale = new Vector3 (0.01F, 0.01F, 0);
			GameObject.FindGameObjectWithTag ("Lives").transform.position = new Vector3 (0.95F, 0.05F, 0);
			obs = GameObject.FindGameObjectWithTag ("Bombs").GetComponent<Instantiating> ().Items;
			for (int x=0; x<obs.Length; x++) {
				obs [x].transform.localScale = new Vector3 (0.7F, 0.7F, 0);

			}

			chars = GameObject.FindGameObjectWithTag ("Fruits").GetComponent<Instantiating> ().Items;
			for (int x=0; x<chars.Length; x++) {
				chars [x].transform.localScale = new Vector3 (1.3F, 1.3F, 0);
				chars [x].GetComponent<Item> ().leftItem.transform.localScale = new Vector3 (1F, 1F, 0);
				
			}
			//print (GameObject.FindGameObjectWithTag ("Points").transform.position);
			
		} else 
		if (ManageCamera.MaxX () > 10 && ManageCamera.MaxX () < 13 && ManageCamera.MinX () > -7 && ManageCamera.MinX () < -3) {

			GameObject.FindGameObjectWithTag ("Skip").transform.localScale = new Vector3 (0.5F, 0.5F, 0);
			GameObject.FindGameObjectWithTag ("Skip").transform.position = new Vector3 (11F, 2.5F, 0);
			GameObject.FindGameObjectWithTag ("bottom").transform.localScale = new Vector3 (1.5F, 1F, 0);
			GameObject.FindGameObjectWithTag ("bottom").transform.position = new Vector3 (3.5F, 1.49F, 0);
			GameObject.FindGameObjectWithTag ("Score").transform.localScale = new Vector3 (0.9F, 0.9F, 0);
			GameObject.FindGameObjectWithTag ("Score").transform.position = new Vector3 (5F, 1.4F, 0);
			GameObject.FindGameObjectWithTag ("recWord").GetComponent<GUIText> ().fontSize = 35;
			GameObject.FindGameObjectWithTag ("recWord").transform.position = new Vector3 (0.4F, 0.05F, 0);
			GameObject.FindGameObjectWithTag ("Points").GetComponent<GUIText> ().fontSize = 30;
			GameObject.FindGameObjectWithTag ("Points").transform.position = new Vector3 (0.2F, 0.04F, 0);
			GameObject.FindGameObjectWithTag ("Lives").transform.localScale = new Vector3 (0.01F, 0.01F, 0);
			GameObject.FindGameObjectWithTag ("Lives").transform.position = new Vector3 (0.85F, 0.05F, 0);
			obs = GameObject.FindGameObjectWithTag ("Bombs").GetComponent<Instantiating> ().Items;
			for (int x=0; x<obs.Length; x++) {
				obs [x].transform.localScale = new Vector3 (1.1F, 1.1F, 0);
				
			}
			
			chars = GameObject.FindGameObjectWithTag ("Fruits").GetComponent<Instantiating> ().Items;
			for (int x=0; x<chars.Length; x++) {
				chars [x].transform.localScale = new Vector3 (1.6F, 1.6F, 0);
				chars [x].GetComponent<Item> ().leftItem.transform.localScale = new Vector3 (1.5F, 1.5F, 0);
				
			}
			//print (GameObject.FindGameObjectWithTag ("Points").transform.position);

	
			
			
			
		} else if (ManageCamera.MaxX () > 7 && ManageCamera.MaxX () < 9 && ManageCamera.MinX () > -0.1 && ManageCamera.MinX () < 0.8) {

			GameObject.FindGameObjectWithTag ("Skip").transform.localScale = new Vector3 (0.6F , 0.6F, 0);
			GameObject.FindGameObjectWithTag ("Skip").transform.position = new Vector3 (6.5F, 3F, 0);
			GameObject.FindGameObjectWithTag ("bottom").transform.localScale = new Vector3 (1F , 1.2F, 0);
			GameObject.FindGameObjectWithTag ("bottom").transform.position = new Vector3 (3.5F, 1.9F, 0);
			GameObject.FindGameObjectWithTag ("Score").transform.localScale = new Vector3 (0.5F ,0.5F, 0 );
			GameObject.FindGameObjectWithTag ("Score").transform.position = new Vector3 (4.5F , 1.4F, 0);
			GameObject.FindGameObjectWithTag ("recWord").GetComponent<GUIText>().fontSize=50;
			GameObject.FindGameObjectWithTag ("recWord").transform.position = new Vector3 (0.4F , 0.05F, 0);
			GameObject.FindGameObjectWithTag ("Points").GetComponent<GUIText>().fontSize=50;
			GameObject.FindGameObjectWithTag ("Points").transform.position = new Vector3 (0.05F , 0.04F, 0);
			GameObject.FindGameObjectWithTag ("Lives").transform.localScale = new Vector3 (0.05F , 0.05F, 0);
			GameObject.FindGameObjectWithTag ("Lives").transform.position = new Vector3 (0.85F , 0.07F, 0);
			obs=GameObject.FindGameObjectWithTag ("Bombs").GetComponent<Instantiating>().Items;
			for (int x=0; x<obs.Length ; x++)
			{
				obs[x].transform.localScale =  new Vector3(1F, 1F, 0);
				
			}
			chars=GameObject.FindGameObjectWithTag ("Fruits").GetComponent<Instantiating>().Items;
			for (int x=0; x<chars.Length ; x++)
			{
				chars[x].transform.localScale =  new Vector3(1.6F, 1.6F, 0);
				chars[x].GetComponent<Item>().leftItem.transform.localScale = new Vector3(1.5F, 1.5F, 0);
				
			}



		}


		else {

			GameObject.FindGameObjectWithTag ("Skip").transform.localScale = new Vector3 (0.9F , 0.9F, 0);
			GameObject.FindGameObjectWithTag ("Skip").transform.position = new Vector3 (8.8F, 2.5F, 0);
			GameObject.FindGameObjectWithTag ("bottom").transform.localScale = new Vector3 (1F , 1.2F, 0);
			GameObject.FindGameObjectWithTag ("bottom").transform.position = new Vector3 (3.5F, 1.9F, 0);
			GameObject.FindGameObjectWithTag ("Score").transform.localScale = new Vector3 (1F ,1F, 0 );
			GameObject.FindGameObjectWithTag ("Score").transform.position = new Vector3 (5F , 1.4F, 0);
			GameObject.FindGameObjectWithTag ("recWord").GetComponent<GUIText>().fontSize=50;
			GameObject.FindGameObjectWithTag ("recWord").transform.position = new Vector3 (0.4F , 0.05F, 0);
			GameObject.FindGameObjectWithTag ("Points").GetComponent<GUIText>().fontSize=50;
			GameObject.FindGameObjectWithTag ("Points").transform.position = new Vector3 (0.04F , 0.04F, 0);
			GameObject.FindGameObjectWithTag ("Lives").transform.localScale = new Vector3 (0.05F , 0.05F, 0);
			GameObject.FindGameObjectWithTag ("Lives").transform.position = new Vector3 (0.85F , 0.04F, 0);
			obs=GameObject.FindGameObjectWithTag ("Bombs").GetComponent<Instantiating>().Items;
			for (int x=0; x<obs.Length ; x++)
			{
				obs[x].transform.localScale =  new Vector3(1F, 1F, 0);
				
			}
						chars=GameObject.FindGameObjectWithTag ("Fruits").GetComponent<Instantiating>().Items;
			for (int x=0; x<chars.Length ; x++)
			{
				chars[x].transform.localScale =  new Vector3(1.7F, 1.7F, 0);
				chars[x].GetComponent<Item>().leftItem.transform.localScale = new Vector3(1.5F, 1.5F, 0);
				
			}

		}
	}
	

}
