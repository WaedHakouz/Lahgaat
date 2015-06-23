using UnityEngine;
using System.Collections;

public class SClip{

	public string URL;
	public int ID;
	public string Dialect;

	public void create( string url , string dia , int id)
	{
		URL=url;
		Dialect=dia;
		ID=id;
	}

	public string toString()
	{

		return URL + "\n" + Dialect + "\n" + ID;
	}



}
