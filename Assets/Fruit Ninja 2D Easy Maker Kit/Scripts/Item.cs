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

	private float rotDirection = 50;
	private string currentDialect;
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
		//print (" ITEM : " + gameObject.tag);

		GameObject tempItem = null;
		
		tempItem = Instantiate (leftItem, transform.position, transform.rotation) as GameObject;
		tempItem.GetComponent<Rigidbody2D>().AddForce (-transform.right * force);
		//Debug.Log (transform.right);
		tempItem.GetComponent<Rigidbody2D>().AddTorque (torque);


		currentDialect = instanObject.GetComponent<playButton> ().getDialect();

		if (currentDialect == gameObject.tag) {
			player.selected1 ();
			Destroy (gameObject);

		} else {
			player.selected2 ();
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
}
