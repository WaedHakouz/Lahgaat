using UnityEngine;
using System.Collections;

public class Database1 : MonoBehaviour 
{
	public static string user = "", country = "";
	private string password = "", rePass = "", message = "";
	public int ID;
	private bool  regAction=false, loginAction = false;


	private void OnGUI()
	{
		GUILayout.BeginArea (new Rect (Screen.width /4 ,  Screen.height/4 , Screen.width / 2,  Screen.height / 2));
		if (message != "")
			GUILayout.Box(message);

		if (GUILayout.Button ("Register")) {
			regAction = true;
		}
		if (GUILayout.Button ("Log in"))
			loginAction = true;

		
		if (regAction) {
			GUILayout.Label ("Username");
			user = GUILayout.TextField (user);
			GUILayout.Label ("Country");
			country = GUILayout.TextField (country);
			GUILayout.Label ("password");
			password = GUILayout.PasswordField (password, "*" [0]);
			GUILayout.Label ("Re-password");
			rePass = GUILayout.PasswordField (rePass, "*" [0]);
			
			GUILayout.BeginHorizontal ();
			
			if (GUILayout.Button ("Back"))
				regAction = false;
			
			if (GUILayout.Button ("Done")) {
				message = "";
				
				if (user == "" || country == "" || password == "")
					message += "Please enter all the fields \n";
				else {
					if (password == rePass) {
						WWWForm form = new WWWForm ();
						form.AddField ("user", user);
						form.AddField ("country", country);
						form.AddField ("password", password);
						WWW w = new WWW ("localhost/register.php", form);
						StartCoroutine (registerFunc (w));
					} else
						message += "Your Password does not match \n";
				}// end of else (Done)

				GUILayout.EndHorizontal ();
			} //end of if Done

		} // end of regAction

		if (loginAction == true)
		{

			GUILayout.Label ("User:");
			user = GUILayout.TextField (user);
			GUILayout.Label ("Password:");
			password = GUILayout.PasswordField (password, "*" [0]);
			
			GUILayout.BeginHorizontal ();
			
			if (GUILayout.Button ("Sign In")) {
				message = "";
				
				if (user == "" || password == "")
					message += "Please enter all the fields \n";
				else {
					WWWForm form = new WWWForm ();
					form.AddField ("user", user);
					form.AddField ("password", password);
					WWW w = new WWW ("localhost/login.php", form);
					StartCoroutine (login (w));
					
				}
			}
			
			if (GUILayout.Button ("Back"))
				loginAction = false;
			
			GUILayout.EndHorizontal ();
		}

		GUILayout.EndArea();
	}
/*	private void OnGUI()
	{
		if (newP == true || prev == true) {



			//GUILayout.BeginArea (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 50));

			//begin registration

			//if (GUILayout.Button ("Create Account")) 
			{

				if (message != "")
					GUILayout.Box (message);

				GUILayout.BeginArea (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 50));
				GUILayout.Label ("Username");
				user = GUILayout.TextField (user);
				GUILayout.Label ("Country");
				country = GUILayout.TextField (country);
				GUILayout.Label ("password");
				password = GUILayout.PasswordField (password, "*" [0]);
				GUILayout.Label ("Re-password");
				rePass = GUILayout.PasswordField (rePass, "*" [0]);
			
				GUILayout.BeginHorizontal ();
			
				if (GUILayout.Button ("Back")) {
					prev = true;
				}
			
				if (GUILayout.Button ("Register")) {
					message = "";
				
					if (user == "" || country == "" || password == "")
						message += "Please enter all the fields \n";
					else {
						if (password == rePass) {
							WWWForm form = new WWWForm ();
							form.AddField ("user", user);
							form.AddField ("country", country);
							form.AddField ("password", password);
							WWW w = new WWW ("localhost/register.php", form);
							StartCoroutine (registerFunc (w));
						} else
							message += "Your Password does not match \n";
					}
				}
			
				newP = false;
				GUILayout.EndHorizontal ();
				GUILayout.EndArea();
			}


/*			  

			if (GUILayout.Button ("Log in")) {
				GUILayout.Label ("User:");
				user = GUILayout.TextField (user);
				GUILayout.Label ("Password:");
				password = GUILayout.PasswordField (password, "*" [0]);
			
				GUILayout.BeginHorizontal ();
			
				if (GUILayout.Button ("Login")) {
					message = "";
				
					if (user == "" || password == "")
						message += "Please enter all the fields \n";
					else {
						WWWForm form = new WWWForm ();
						form.AddField ("user", user);
						form.AddField ("password", password);
						WWW w = new WWW ("localhost/login.php", form);
						StartCoroutine (login (w));
						newP = false;
				
					}
				}
			
				if (GUILayout.Button ("Back"))
					prev = true;
			
				GUILayout.EndHorizontal ();
			}

		

			if (GUILayout.Button ("Play without an account")) {

				WWWForm form = new WWWForm ();
				form.AddField ("user", "");
				form.AddField ("country", "");
				form.AddField ("password", "");
				WWW w = new WWW ("localhost/register.php", form);
				StartCoroutine (registerFunc (w));
				newP=false;
				
			}

			GUILayout.EndArea();
		}// end of if newP

	
	}// end of onGUI
*/

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
			print ("in if of regfunc");
			message += w.text;
			int.TryParse(w.text ,out ID);
			//gameObject.GetComponent<Player>().setID(ID);
		}
		else
		{
			print ("in else");
			message += "ERROR: " + w.error + "\n";

		}
	}
}
