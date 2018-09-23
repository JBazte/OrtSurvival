using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

    public static bool mcExists;
    public AudioSource[] soundTracks;
    public int currentTrack;
    public bool MusicCanPlay;

	// Use this for initialization
	void Start () {
        if (!mcExists)
        {
            mcExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (MusicCanPlay)
        {
            if (!soundTracks[currentTrack].isPlaying)
            {
                soundTracks[currentTrack].Play();
            }
        }
        else
        {
            soundTracks[currentTrack].Stop();
        }
	}
    public void SwitchTrack(int newTrack)
    {
        if (currentTrack != newTrack)
        {
            soundTracks[currentTrack].Stop();
            currentTrack = newTrack;
            soundTracks[currentTrack].Play();
        }
    }
}
