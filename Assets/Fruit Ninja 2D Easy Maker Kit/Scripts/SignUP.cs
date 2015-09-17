using UnityEngine;
using System.Collections;

public class SignUP : MonoBehaviour {


	public static string user = "" , country="";
	private string password = "",  rePass = "", message = "";
	public GameObject incomplete, mismatch;
	public int ID;
	
	
	
	public void fillUser(string Muser)
	{
		
		user = Muser;
	}
	
	
	
	public void fillPass(string pass)
	{
		
		password = pass;
	}

	public void fillRePass(string rpass)
	{
		
		rePass = rpass;
	}


	public void fillCountry(string countrc)
	{
		
		country=countrc;
	}
	
	public void submit()
	{
	

		message = "";
				
		if (user == "" || country == "" || password == "")
		{
			mismatch.SetActive (false);
			incomplete.SetActive (true);
		}
				else {
					incomplete.SetActive (false);
					if (password == rePass) {
						WWWForm form = new WWWForm ();
						form.AddField ("user", user);
						form.AddField ("country", country);
						form.AddField ("password", password);
						WWW w = new WWW ("http://qatsdemo.cloudapp.net/lahajet/phpScripts/register.php", form);
						StartCoroutine (registerFunc (w));

					} else
						{
							incomplete.SetActive (false);
							mismatch.SetActive (true);
							
						}
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
			print (ID);
			LoadSave.Save(ID);
			Application.LoadLevel("original");

		}
		else
		{
			message += "ERROR: " + w.error + "\n";
			
		}
	}
}

