using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float rotationSpeed = 100.0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightShift))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

       
        float pitch = -Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float yaw = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        float roll = 0.0f;
        if (Input.GetKey(KeyCode.Space))
        {
            roll = -rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            roll = rotationSpeed * Time.deltaTime;
        }
        
        transform.Rotate(new Vector3(pitch, yaw, roll), Space.Self);
    }
}
