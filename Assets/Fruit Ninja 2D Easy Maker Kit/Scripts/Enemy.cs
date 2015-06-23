using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public bool isDead;
	private Vector3 screen;
	public float minY;
	public float maxY;
	public float rotDirection = 50;
	public Player player;

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

		transform.Rotate (new Vector3 (0, 0, rotDirection) * Time.deltaTime);
	}


	public void  OnMouseDown ( ) {

		player.selected2 ();
		Destroy (gameObject);
	}
}
