using UnityEngine;

public class Orbiter : MonoBehaviour
{
    [SerializeField] private Transform centerPoint;
    [SerializeField] private float orbitalSpeed = 20f;
    [SerializeField] private float rotationSpeed = 15f;
    [SerializeField] private Vector3 orbitalAxis = Vector3.up;

    void Update()
    {
        if (centerPoint != null)
        {
            transform.RotateAround(centerPoint.position, orbitalAxis, orbitalSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}