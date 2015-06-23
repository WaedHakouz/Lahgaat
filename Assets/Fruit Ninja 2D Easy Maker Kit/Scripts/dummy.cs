using UnityEngine;
using System.Collections;

public class dummy : MonoBehaviour {

	public string[] data1, data2;
	public SClip[] clip = new SClip [2];
	public string f="sasas-asasa-hghgh";

	
	// Use this for initialization
	void Start () {
	
		WWWForm form = new WWWForm ();
		form.AddField ("Action","getURLs");
		WWW w = new WWW ("localhost/URL.php", form);
		StartCoroutine (scoreFunc (w));
	}



	IEnumerator scoreFunc(WWW w)
	{
		yield return w;
		if (w.error == null)
		{
			print ("in if ");
			print (w.text);
			data1 = w.text.Split('\n');
			for (int i=0 ; i<data1.Length-1; i++)
			{
				data2=data1[i].Split(',');
				clip[i]=new SClip();

				clip[i].create(data2[0], data2[1] , int.Parse(data2[2]));

				print(clip[i].URL + "\n" + clip[i].Dialect + "\n" + clip[i].ID);



			}

		}
		else
		{
			print ("in else ");
			print ( "ERROR: " + w.error + "\n");
			
		}
	}

}
