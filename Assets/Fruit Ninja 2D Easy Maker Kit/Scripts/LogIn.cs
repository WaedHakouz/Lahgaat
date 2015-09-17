using UnityEngine;
using System.Collections;

public class LogIn : MonoBehaviour {

	public static string user = "";
	private string password = "", message = "";
	public GameObject incomplete;




	public void fillUser(string Muser)
	{

		user = Muser;
	}

	

	public void fillPass(string pass)
	{
		
		password = pass;
	}


	public void submit()
	{


		if (message != "")
			print (message);

		if (user == "" || password == "")
			incomplete.SetActive (true);
		else {
				WWWForm form = new WWWForm ();
				form.AddField ("user", user);
				form.AddField ("password", password);
				WWW w = new WWW ("http://qatsdemo.cloudapp.net/lahajet/phpScripts/login.php", form);
				StartCoroutine (login (w));	
				

			}


	}


	IEnumerator login(WWW w)
	{
		yield return w;
		if (w.error == null)
		{
			
			if (w.text == "login-SUCCESS")
			{	message += w.text;
				print("WOOOOOOOOOOOOOOO!");
				Application.LoadLevel("original");
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
}
