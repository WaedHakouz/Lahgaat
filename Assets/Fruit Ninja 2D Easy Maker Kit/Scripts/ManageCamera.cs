using UnityEngine;
using System.Collections;

public class ManageCamera : MonoBehaviour {
	
	public Camera camera;
	private static float minX;
	private static float maxX;
	private static float minY;
	private static float maxY;

	private float distanceZ;

	// Use this for initialization
	void Update () 
	{

		distanceZ = transform.position.z - camera.transform.position.z;
		minX = camera.ScreenToWorldPoint (new Vector3 (0, 0, distanceZ)).x;
		maxX = camera.ScreenToWorldPoint (new Vector3 (Screen.width, 0, distanceZ)).x;
		minY = camera.ScreenToWorldPoint (new Vector3 (0, 0, distanceZ)).y;
		maxY = camera.ScreenToWorldPoint (new Vector3 (Screen.height, distanceZ)).y;


	}

	public static float MinX()
	{
		return minX;
	}
	public static float MaxX()
	{
		return maxX;
	}

	public static float MinY()
	{
		return minY;
	}
	public static float MaxY()
	{
		return maxY;
	}
}
