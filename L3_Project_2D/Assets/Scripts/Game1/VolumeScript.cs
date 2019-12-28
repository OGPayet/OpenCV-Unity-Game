using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeScript : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource audiosrc;
    private float musicVolume = 1f;

    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audiosrc.volume = musicVolume;
    }

    public void SetVolume()
    {
       musicVolume = audiosrc.volume;
    }
}

