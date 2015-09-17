using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	private int record;
	private static int points = 0;
	public GameObject textPoints;

	// Use this for initialization
	void Start () 
	{
		LoadSave.Load ();
		points = 0;
		GetComponent<GUIText>().text = "0";
		WWWForm form = new WWWForm ();
		form.AddField ("Action","getScore");
		form.AddField ("ID", LoadSave.ID);
		WWW w = new WWW ("http://qatsdemo.cloudapp.net/lahajet/phpScripts/score.php", form);
		StartCoroutine (scoreFunc (w));

		textPoints.GetComponent<GUIText> ().text =getRecord ().ToString();
			//PlayerPrefs.GetInt("Record").ToString();
		//Record();
	}
	
	public void Hit()
	{
		points=points+3;
		GetComponent<GUIText>().text = points.ToString ();
	}

	public void Record()
	{
		//record = PlayerPrefs.GetInt ("Record");

		//if (points > PlayerPrefs.GetInt ("Record")) 
		{  
			//PlayerPrefs.SetInt ("Record", points+record);
			setRecord(points+getRecord());
			WWWForm form = new WWWForm ();
			form.AddField ("Action","updateScore");
			form.AddField ("ID", LoadSave.ID);
			form.AddField ("SCORE", record );
			WWW w = new WWW ("http://qatsdemo.cloudapp.net/lahajet/phpScripts/score.php", form);
			StartCoroutine (scoreFunc (w));
		}
		//if (textPoints != null) 
	
	}

	public void setRecord( int rec)
	{
		
		record=rec;
	}
	
	
	public int getRecord()
	{
		return record;
	}


	IEnumerator scoreFunc(WWW w)
	{
		yield return w;
		if (w.error == null)
		{
			int.TryParse(w.text, out record);
			textPoints.GetComponent<GUIText> ().text =  getRecord ().ToString();
			
		}
		else
		{
			print ("in else ");
			print ( "ERROR: " + w.error + "\n");
			
		}
	}
}
