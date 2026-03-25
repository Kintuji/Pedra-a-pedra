using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class TVController : MonoBehaviour
{
    [SerializeField] VideoPlayer _videoPlayer;
    [SerializeField] Material _onMaterial;
    [SerializeField] Material _offMaterial;
    [SerializeField] Renderer _render;

    private bool _isOn = true;

    private void Awake()
    {
     //   _render = GetComponent<Renderer>();
    }

    public void ToggleTV()
    {
        if (_isOn)
        {
            Debug.Log("Turning TV Off");
            _render.material = _offMaterial;
            _videoPlayer.Stop();
            _isOn = false;

        }
        else
        {
            _render.material = _onMaterial;
            _videoPlayer.Prepare();
            _videoPlayer.Play();
            _isOn = true;
        }
    }

    public void TogglePlayPause()
    {
        if (!_isOn) return;

        if (_videoPlayer.isPlaying)
        {
            _videoPlayer.Pause();
        }
        else
        {
            if (!_videoPlayer.isPrepared)
            {
                _videoPlayer.Prepare();
                return;
            }

            _videoPlayer.Play();
        }
    }
    public void RestartVideo() 
    { 
        if (!_isOn) return;
        
        StartCoroutine(RestartCooldown());

    }

    IEnumerator RestartCooldown()
    {
        _videoPlayer.Stop();
        _render.material = _offMaterial;
        yield return new WaitForSeconds(1f);

        _videoPlayer.Prepare();
        _videoPlayer.Play();
    }
}
