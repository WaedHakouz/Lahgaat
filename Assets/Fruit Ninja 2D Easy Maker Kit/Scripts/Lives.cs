using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	public Texture2D[] Life;
	private int sizeLives;
	private int index = 0;

	// Use this for initialization
	void Start () 
	{
		GetComponent<GUITexture>().texture = Life[0];
		sizeLives = Life.Length;
	}

	public bool Remover()
	{
		if ((sizeLives < 0)) 
		{
			return false;
		}
		if (index < (sizeLives - 1)) 
		{
			index += 1;
			GetComponent<GUITexture>().texture = Life[index];
			return true;
		} 
		else 
		{
			return false;
		}
	}
}
