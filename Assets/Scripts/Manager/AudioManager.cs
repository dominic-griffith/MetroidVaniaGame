using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioMixerGroup musicMixerGroup;
    public AudioMixerGroup SFXMixerGroup;
    public Sound[] sounds;

    private void Awake()
    {
        //Singleton Design Pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }


        //Assign atributes to the sound
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            switch(s.audioType)
            {
                case (Sound.AudioTypes.SFX):
                    s.source.outputAudioMixerGroup = SFXMixerGroup;
                    break;
                case (Sound.AudioTypes.music):
                    s.source.outputAudioMixerGroup = musicMixerGroup;
                    break;
            }
        }
    }

    private void Start()
    {
        //Play("Music");
    }

    public static AudioManager GetInstance()
    {
        return Instance;
    }


    //Play/Stop Audio Clip
    //ex use: AudioManager.GetInstance().Play("name");
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found.");
            return;
        }
            
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found.");
            return;
        }

        s.source.Stop();
    }
}
