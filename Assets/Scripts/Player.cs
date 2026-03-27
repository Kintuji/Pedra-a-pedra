using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class Player : MonoBehaviour
{
    [SerializeField] private ContinuousMoveProvider _move;
    [SerializeField] private ContinuousTurnProvider _turn;
    [SerializeField] private AudioSource _stepAudio;

    private void Awake()
    {
        _move.enabled = false;
        _turn.enabled = false;
    }

    private void OnEnable()
    {
        _move.beginLocomotion += OnMoveStart;
        _move.endLocomotion += OnMoveStop;
    }

    private void OnDisable()
    {
        _move.beginLocomotion -= OnMoveStart;
        _move.endLocomotion -= OnMoveStop;
    }

    private void OnMoveStart(LocomotionSystem system)
    {
        if (!_stepAudio.isPlaying)
            _stepAudio.Play();
    }

    private void OnMoveStop(LocomotionSystem system)
    {
        _stepAudio.Stop();
    }

    public void EnablePlayerConfig()
    {
        _move.enabled = true;
        _turn.enabled = true;
    }
}