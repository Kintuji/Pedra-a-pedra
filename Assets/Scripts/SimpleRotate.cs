using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 0, 90);

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}