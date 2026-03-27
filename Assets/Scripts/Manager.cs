using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> _spriteRenders;
    [SerializeField] private List<Sprite> _buttonsCover;
    [SerializeField] private List<Sprite> _buttonsSprite;
    [SerializeField] private List<GameObject> _uIButtons;
    [SerializeField] private Player _player;
    [SerializeField] private Animator _doorAnimator;

    [SerializeField] private AudioSource musicSource;

    private void Start()
    {
        SoundManager.PlaySound(SoundType.MAINMENU);
    }
    public void OpenDoor()
    {
        _doorAnimator.SetTrigger("Open");
    }
    public void PlayButtonEffect()
    {
        _spriteRenders[0].sprite = _buttonsCover[0];
    }
    public void ExitButtonEffect()
    {
        _spriteRenders[1].sprite = _buttonsCover[1];
    }

    public void SetPlaySprite()
    {
        _spriteRenders[0].sprite = _buttonsSprite[0];
    }
    public void SetExitSprite()
    {
        _spriteRenders[1].sprite = _buttonsSprite[1];
    }
    public void PlayButton()
    {
        SoundManager.Instance.StopMusic(musicSource);

        for (int i = 0; i < _uIButtons.Count; i++)
        {
            _uIButtons[i].SetActive(false);
        }

        _player.EnablePlayerConfig();
        SoundManager.PlaySound(SoundType.AMBIENCE);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
