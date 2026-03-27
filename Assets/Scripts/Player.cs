using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class Player : MonoBehaviour
{
    [SerializeField] private ContinuousMoveProvider _move;
    [SerializeField] private ContinuousTurnProvider _turn;

    private void Awake()
    {
        _move.enabled = false;
        _turn.enabled = false;
    }
    public void EnablePlayerConfig()
    {
        _move.enabled = true;
        _turn.enabled = true;
    }
}
