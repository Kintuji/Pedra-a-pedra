using UnityEngine;

public class UIButtons : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderPlay;
    [SerializeField] private SpriteRenderer _spriteRenderPause;
    
    [SerializeField] private Sprite _spritePlay;
    [SerializeField] private Sprite _spritePlayEffect;
    
    [SerializeField] private Sprite _spritePause;
    [SerializeField] private Sprite _spritePauseEffect;

    public void PlayButton()
    {
        _spriteRenderPlay.sprite = _spritePlay;
    }
    public void PlayButtonEffect()
    {
        _spriteRenderPlay.sprite = _spritePlayEffect;
    }
    public void PauseButton()
    {
        _spriteRenderPause.sprite = _spritePause;
    }
    public void PauseButtonEffect()
    {
        _spriteRenderPause.sprite = _spritePauseEffect;
    }

}
