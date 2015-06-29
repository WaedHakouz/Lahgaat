using UnityEngine;
using System.Collections;
using System.Threading;
//using System.Collections.Generic;

public class playButton : MonoBehaviour {
	

	public string[] data1, data2;
	public AudioSource source;
	public AudioSource source1;
	public AudioClip ding;
	private Queue clips = new Queue() , dialects = new Queue() , IDs = new Queue();
	public GameObject skipB;
	public SClip[] allClips = new SClip[8];
	public string currentDialect ;
	public int currentID;
	//private  www;

	void Start() {

		source = GetComponent<AudioSource> ();
		getURLs ();
	}


	void Update () 
	{

		print (clips.Count);

		if (!source.isPlaying && clips.Count > 0 && !source1.isPlaying)
		{
			source1.clip=ding;
			source1.Play();

		}



		if (!source.isPlaying && clips.Count > 0)
		{
			Thread.Sleep(600);

			source.clip = (AudioClip)clips.Dequeue ();
			currentDialect = (string) dialects.Dequeue();
			currentID = (int)IDs.Dequeue();
			source.Play ();
			print ("Clip Dialect : "+currentDialect);
			print ("Clip ID : "+currentID);
		}

		if (clips.Count == 2)
			getURLs ();

		//playClips ();

		//print (clips.Count);

		//if (clips.Count == clips.Count / 2)
			//print ("reached half");
			//StartCoroutine (getURLs ());
	}


	public void playClips ()
	{
		//while (true) // && !source.isPlaying )
		{	
			/*if (!source.isPlaying && clips.Count > 0)
			{
				print (clips.Count);
				source.clip = (AudioClip)clips.Dequeue ();
				source.Play ();
				print(source.isPlaying);
			}*/

		//	else if (clips.Count == 0)
				//break;
			//Invoke("nothing",11);

					
			//print(source.isPlaying);
			//playClips();
		}
		/*if (clips.Count >= 0 && !source.isPlaying ) 
		{
			source.clip = (AudioClip)clips.Dequeue ();
			source.Play ();
			playClips();
		}*/
	}


	public void getURLs()
	{

		WWWForm form = new WWWForm ();
		form.AddField ("Action","getURLs");
		WWW w = new WWW ("localhost/URL.php", form);
		StartCoroutine (scoreFunc (w));
	


	}


	public IEnumerator clipLoaded (WWW www , string dia , int id)
	{	//print ("first");
		yield return www;
		//print ("first2");

		if (www.error == null) {
			clips.Enqueue (www.GetAudioClip (false, true));
			dialects.Enqueue( dia);
			IDs.Enqueue(id);

		} 

		else {
			Debug.Log ("Error " + www.error);
			print("Error " + www.error);
		}

			



		/*if (clips.Count > 0 ) {

			//StartCoroutine(playFiles());
			Start function the new one 
			 (source.clip = (AudioClip)clips.Dequeue ();
			source.Play();
			invoke it in update when the count is greater than 0 it should start playing
				 )
		} else {

		}*/
	}





	public void skip()
	{
		source.clip = (AudioClip)clips.Dequeue ();
		currentDialect = (string) dialects.Dequeue ();
		currentID = (int)IDs.Dequeue ();
		source1.clip=ding;
		source1.Play();
		Thread.Sleep(600);
		source.Play ();
		print ("Clip Dialect : "+currentDialect);
		print ("Clip ID : "+currentID);


	}



	IEnumerator scoreFunc(WWW w)
	{
		yield return w;
		if (w.error == null)
		{

			data1 = w.text.Split('\n');
			//print (data1.Length);

			for (int i=0 ; i<data1.Length-1; i++)
			{
				data2=data1[i].Split(',');
				allClips[i]=new SClip();

				allClips[i].create(data2[0], data2[1] , int.Parse(data2[2]));
				
				//print(allClips[i].URL + "\n" + allClips[i].Dialect + "\n" + allClips[i].ID);
						
				
			}

			for (int i=0; i<allClips.Length; i++) {
				if ( i==3 )
				{	
					Thread.Sleep(600);
				}

				WWW www = new WWW (allClips[i].URL);
				StartCoroutine (clipLoaded (www , allClips[i].Dialect , allClips[i].ID));

			

								

					
	

			}
			
		}
		else
		{
			print ("in else ");
			print ( "ERROR: " + w.error + "\n");
			
		}

	}

	public string getDialect()
	{
		return currentDialect;
	}


	public int getID()
	{
		return currentID;
	}

	 IEnumerator Example(int i) {

		yield return new WaitForSeconds(5);
		
	}
}



