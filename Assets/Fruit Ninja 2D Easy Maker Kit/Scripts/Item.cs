using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public GameObject leftItem;
	public GameObject rightItem , instanObject;
	public GameObject ink;
	public bool clicked;
	public Player player;
	public float force;
	public float torque;
	private bool isDead;
	private Vector3 screen;

	public float alpha;
	public float red;
	public float green;
	public float blue;

	public float minY;
	public float maxY;
	
	private string currentDialect;
	private int currentID;
	//private GameObject access;


	public void setPlayer(Player p)
	{
		player = p;
	}
	// Use this for initialization
	void Start () 
	{
		minY = ManageCamera.MinY ();
		maxY = ManageCamera.MaxY ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		Remover ();
	}

	public void Remover()
	{
		screen = Camera.main.WorldToScreenPoint (transform.position);

		if (isDead && screen.y < minY) 
		{
			Destroy (gameObject);
		} 
		else 
		{
			isDead = true;
		}
	}

	public void  OnMouseDown ( ) {
		print (" ITEM : " + gameObject.tag);

		GameObject tempItem = null;
		
		tempItem = Instantiate (leftItem, transform.position, transform.rotation) as GameObject;
		tempItem.GetComponent<Rigidbody2D>().AddForce (-transform.right * force);
		//Debug.Log (transform.right);
		tempItem.GetComponent<Rigidbody2D>().AddTorque (torque);


		currentDialect = instanObject.GetComponent<playButton> ().getDialect();
		currentID = instanObject.GetComponent <playButton>().getID ();
		WWWForm form = new WWWForm ();
		form.AddField ("Action","setDialect");
		form.AddField ("ID", currentID);
		form.AddField ("Dialect", gameObject.tag);
		WWW w = new WWW ("localhost/URL.php", form);
		StartCoroutine (setDialectFunc (w));

		if (currentDialect == "NOR" || currentDialect == "LAV" || currentDialect == "EGY" || currentDialect == "GLF"  ) {



			if (currentDialect == gameObject.tag) {
				player.selected1 ();
				Destroy (gameObject);

			} else {
				player.selected2 ();
				Destroy (gameObject);
			}

		} 

		else {

			player.selected1 ();
			Destroy (gameObject);

		}
		instanObject.GetComponent<playButton> ().skip();

		//if (gameObject.tag == "Bombs") {
			//player.selected2 ();
			//Destroy (gameObject);
	//	}

		//player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> () 
			//as Player;

		//GameObject player = GameObject.FindWithTag("Player");
		//Player p = player.GetComponent<Player> ();
	/*	if (gameObject.tag == "Fruits") 
		{
			DestroyInstantiating();

			player.selected1();
		}
		else if (gameObject.tag == "Bombs") 
		{
			gameObject.SetActive(false);
			player.selected2();
		}*/
		//gameObject.active = false;
		//Destroy(gameObject);
		//renderer.enabled = false;
	}
	/*public void DestroyInstantiating()
	{

		GameObject tempItem = null;
		//GameObject tempInk = null;

		//tempItem = Instantiate (leftItem, transform.position, transform.rotation) as GameObject;
		//tempItem.GetComponent<Rigidbody2D>().AddForce (-transform.right * force);
		//Debug.Log (transform.right);
		//tempItem.GetComponent<Rigidbody2D>().AddTorque (torque);

		//tempItem = Instantiate (rightItem, transform.position, transform.rotation) as GameObject;
		//tempItem.GetComponent<Rigidbody2D>().AddForce (-transform.right * force);
		//tempItem.GetComponent<Rigidbody2D>().AddTorque (torque);

		//tempInk = Instantiate (ink, new Vector2 (transform.position.x, transform.position.y),
		                     // transform.rotation) as GameObject;

		//tempInk.GetComponent<Ink>().SetColor(red, green, blue, alpha);

		//Destroy (gameObject);
	}*/


	IEnumerator setDialectFunc(WWW w)
	{
		yield return w;
		if (w.error == null)
		{
			print ( w.text);
		}
		else
		{
			print ("Error Occurred : " + w.error );

		}
	}
}
