using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private Vector3 position;
	private bool death ;
	private HighScore points;
	private Lives life;
	public GameObject gameOver;
	public AudioClip obsClip;
	public AudioClip charClip;
	public AudioClip losClip;
	public AudioSource source;
	private int  sScore ,ID;

	
	TrailRenderer trail;
	
	void Awake()
	{
		gameOver.SetActive (false);
		points = GameObject.FindGameObjectWithTag ("Points").GetComponent<HighScore> () 
			as HighScore;
		life = GameObject.FindGameObjectWithTag ("Lives").GetComponent<Lives> () 
			as Lives;

	}
	
	// Use this for initialization
	void Start () 
	{

		source = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		Platform ();
	}
	
	private void Platform()
	{
		if (Application.platform == RuntimePlatform.Android) 
		{
			if (Input.touchCount == 1) 
			{
				position = Camera.main.ScreenToWorldPoint
					(new Vector3 (Input.GetTouch (0).position.x,
					              Input.GetTouch (0).position.y,1));
				
				transform.position = new Vector2 (position.x, position.y);
				
				GetComponent<Collider2D>().enabled = true;
				return;
			}
			GetComponent<Collider2D>().enabled = false;
		} 
		else 
		{
			position = Camera.main.ScreenToWorldPoint
				(new Vector3 (Input.mousePosition.x,
				              Input.mousePosition.y,0));
			
			transform.position = new Vector2 (position.x, position.y);
		}
	}

	public void selected1()
	{
		source.clip = charClip;
		source.Play ();
		points.Hit();
	} 



	public void selected2()
	{
		source.clip = obsClip;
		source.Play ();

		if(!life.Remover())
		{
			GetComponent<Collider2D>().enabled = false;
			gameOver.SetActive (true);
			source.clip = losClip;
			source.Play ();
			points.Record();
			Invoke ("LoadLevel", 4f);

		}
	}

	
	/*void Audio(AudioClip clip)
	{
		GetComponent<AudioSource>().clip = clip;
		AudioSource.PlayClipAtPoint (clip, transform.position, 0.2f);
	}*/
	
	void LoadLevel()
	{
		print("in LoadLevel");
		Application.LoadLevel ("Again");
	}


	IEnumerator serverScore(WWW w)
	{
		yield return w;
		if (w.error == null)
		{
		
			int.TryParse(w.text ,out sScore);
			print (w.text);
			
		}
		else
		{
			print ( "ERROR: " + w.error + "\n");
			
		}
	}


	public void setID( int id)
	{
		ID = id;
	}

	public int getID ()
	{
		return ID;
	}

}
