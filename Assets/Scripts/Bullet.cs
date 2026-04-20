using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody=GetComponent<Rigidbody>();
    }
    public void Logic(float speed)
    {
        rigidbody.AddForce(transform.forward * speed);
    }
}
