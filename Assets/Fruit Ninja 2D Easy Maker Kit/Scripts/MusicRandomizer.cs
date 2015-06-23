/* Save under MusicRandomizer.cs */
using UnityEngine;
using System.Collections;

public class MusicRandomizer : MonoBehaviour 
{
	private int curAudio = 0;
	// Current audio file selected, out of an array.
	// Inside of a C# array, the first element is listed as [0],
	// so we set curMusic to 0
	public AudioSource source;
	public AudioClip[] clips; // Define in editor
	
	private void Update()
	{
		print (curAudio);
		if(!source.isPlaying)
			// If no audio is playing
		{

			
			source.clip = clips[curAudio];
			// Set game objects audio clip
			
			source.Play();
			// Play game objects audio clip
			
			curAudio++;
			// Increment curAudio

			
			if(curAudio == clips.Length)
			{
				curAudio = 0;
				// If curAudio is higher than your total clips, set back to 0
			}
		}
		
	}
	
}