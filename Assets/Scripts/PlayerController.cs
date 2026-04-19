using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 nextPos = transform.forward * (speed * Time.deltaTime);
            transform.position += nextPos;
        }
        ;

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 nextPos = -transform.forward * (speed * Time.deltaTime);
            transform.position += nextPos;
        }
        ;

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 nextPos = -transform.right * (speed * Time.deltaTime);
            transform.position += nextPos;
        }
        ;

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 nextPos = transform.right * (speed * Time.deltaTime);
            transform.position += nextPos;
        }
        ;
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 nextPos = transform.up * (speed * Time.deltaTime);
            transform.position += nextPos;
        }
        ;
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Vector3 nextPos = -transform.up * (speed * Time.deltaTime);
            transform.position += nextPos;
        }
        ;
    }
}
