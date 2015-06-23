using UnityEngine;
using System.Collections;

public class Database : MonoBehaviour 
{
	public static string user = "", country = "";
	private string password = "", rePass = "", message = "";
	public int ID;

	private bool register = false , newP = true , prev=false;
	//(Screen.width)/4 , (Screen.height)/4, (Screen.width)/2 , (Screen.height)/2)
	private void OnGUI()
	{
		if (newP == true || prev == true) {



			//GUILayout.BeginArea (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 500, 500));


			//begin registration
			GUILayout.Button("Hi");
			if (GUILayout.Button ("Create Account")) 
			{
				print ("in here");
				GUILayout.BeginHorizontal("box");
				GUILayout.Button ("button2");
				GUILayout.EndHorizontal();
			}
			GUILayout.Button("Hi2");

		





		//	GUILayout.EndArea();
		}// end of if newP

	

	}// end of onGUI


	IEnumerator login(WWW w)
	{
		yield return w;
		if (w.error == null)
		{

			if (w.text == "login-SUCCESS")
			{	message += w.text;
				print("WOOOOOOOOOOOOOOO!");
			}
			else {print ("in else");
				message += w.text;

			}
		}
		else
		{ 
			message += "ERROR: " + w.error + "\n";
		}
	}
	
	IEnumerator registerFunc(WWW w)
	{
		yield return w;
		if (w.error == null)
		{

			message += w.text;
			int.TryParse(w.text ,out ID);
			//gameObject.GetComponent<Player>().setID(ID);
		}
		else
		{
			message += "ERROR: " + w.error + "\n";

		}
	}
}
