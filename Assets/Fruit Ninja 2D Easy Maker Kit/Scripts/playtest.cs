using UnityEngine;
using System.Collections;

public class playtest : MonoBehaviour {


	public GameObject other;
	public AudioSource source;
	public AudioClip mclip;

	void update()
	{
		if (!source.isPlaying && !other.GetComponent<AudioSource >().isPlaying )
		{
			source.clip= mclip;
			source.Play ();

		}
	}
}