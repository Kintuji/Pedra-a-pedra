using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> _spriteRenders;
    [SerializeField] private List<Sprite> _buttonsCover;
    [SerializeField] private List<Sprite> _buttonsSprite;
    [SerializeField] private List<GameObject> _uIButtons;
    [SerializeField] private Player _player;
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
        for (int i = 0; i < _uIButtons.Count; i++)
        {
            _uIButtons[i].SetActive(false);
        }

        _player.EnablePlayerConfig();
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
