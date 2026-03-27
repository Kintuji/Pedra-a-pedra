using UnityEngine;

public enum SoundType
{
    MAINMENU,
    AMBIENCE
}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundList;
    [SerializeField] private AudioSource musicSource;

    public static SoundManager Instance;

    private AudioSource sfxSource;

    private void Awake()
    {
        Instance = this;
        sfxSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(SoundType sound, float volume = 1f)
    {
        Instance.sfxSource.PlayOneShot(Instance.soundList[(int)sound], volume);
    }
    public void PlayMusic(SoundType sound, float volume = 1f)
    {
        Instance.musicSource.clip = Instance.soundList[(int)sound];
        Instance.musicSource.loop = true;
        Instance.musicSource.volume = volume;
        Instance.musicSource.Play();
    }

    public void StopMusic(AudioSource audio)
    {
        audio.Stop();
    }
}