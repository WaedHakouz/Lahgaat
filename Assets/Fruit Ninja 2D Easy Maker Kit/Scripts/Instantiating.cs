using UnityEngine; 
using System.Collections; 

public class Instantiating: MonoBehaviour {
	
	public float minSpawnTime; 
	public float maxSpawnTime; 
	public float spawnItem; 
	
	public GameObject [] Items; 
	private GameObject Item; 
	private int index; 
	private Player player;
	public GameObject mplayer , playButton;
	public string currentDia;

	public float upForce = 400f; 
	public float leftForce = 200f; 
	public static float minX, maxX; // Position of instantiator

	// Use this for initialization 
	void Start () 
	{ 
		minX = ManageCamera.MinX();
		maxX = ManageCamera.MaxX(); 
		StartCoroutine ("Instantiator"); //used to call the Instantiator function as soon as the code is executed
		player = mplayer.GetComponent<Player>();


	} 
	
	// Update is called once per frame 
	void Update () { 
		
	} 

	bool RandomItem () // fucntion returns true/false to know if there are items in the array
	{ 
		if (Items.Length > 0) 
		{ 
			index = Random.Range(0, Items.Length); // gives a random index to get a random item in the array
			return true; 
		} 
		return false; 
	} 

	private IEnumerator Instantiator () 
	{ 
		spawnItem = Random.Range (minSpawnTime, maxSpawnTime); 
		yield return new WaitForSeconds (spawnItem); 

		if (RandomItem ()) 
		{ 
			// the function Instantiate is used to clone an item and place it somewhere
			Item = Instantiate (Items [index], new Vector2 (Random.Range (minX, maxX), transform.position.y) 
			       , Quaternion.Euler (0,0, Random.Range (-60, 60))) as GameObject; 

			 

			if (Item.tag.ToString()!= "Bombs")   
			{
				Item.GetComponent<Item>().player = player;
				Item.GetComponent<Item>().instanObject = playButton;
			} 	else if (Item.tag.ToString()== "Bombs")   
			{
				Item.GetComponent<Enemy>().player = player;
			} 


			/*
			Player player = player.GetComponent<Player>();
			if ( player == null )
			{
				print("player is null");
				player = null ;
			} */

			//if( Item.GetComponent<Item>().tag == "Fruits")
			//{
				
			//}
			//else if (Item.GetComponent<Enemy>().tag == "Bombs")
			//{
				//Item.GetComponent<Enemy>().player = player;
			//}

			if (Item.transform.position.x> 0) 
			{ 
				Item.GetComponent<Rigidbody2D>().AddForce (new Vector2 (-leftForce, upForce)); 
			} 
			else 
			{ 
				Item.GetComponent<Rigidbody2D>().AddForce (new Vector2 (leftForce, upForce)); 
			} 
			StartCoroutine ("Instantiator"); 
		} 
	}



}