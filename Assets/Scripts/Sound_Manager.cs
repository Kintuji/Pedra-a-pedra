using UnityEngine;

public enum SoundType
{
    MAINMENU,
    AMBIENCE,
}

[RequireComponent(typeof(AudioSource))]
public class Sound_Manager : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundList;
    public static Sound_Manager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public static void PlaySound(SoundType sound, float volume = 1)
    {
        instance.audioSource.PlayOneShot(instance.soundList[(int)sound], volume);
    }
}
