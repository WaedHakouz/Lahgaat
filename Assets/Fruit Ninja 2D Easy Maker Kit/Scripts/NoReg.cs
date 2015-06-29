using UnityEngine;
using System.Collections;

public class NoReg : MonoBehaviour {


		
		
		public static string user = "" , country="";
		private string password = "" , message = "";
		public int ID;
		
		
		
		
		public void submit()
		{
			
			
			message = "";
			user = "";
			country = "" ;
			password = "" ;

			WWWForm form = new WWWForm ();
			form.AddField ("user", user);
			form.AddField ("country", country);
			form.AddField ("password", password);
			WWW w = new WWW ("localhost/noReg.php", form);
			StartCoroutine (registerFunc (w));
			
			
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
