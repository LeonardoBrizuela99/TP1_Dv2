using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float rotationSpeed = 100.0f;
    [SerializeField] private float bulletSpeed = 0.0f;
    [SerializeField] private Bullet prefabBullet;
    [SerializeField] private Transform tip;
    [SerializeField] private Transform bulletContent;

    private void Update()
    {
        Shoot();
        PlayerMovement();
    }
    private void Shoot()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (prefabBullet != null && tip != null)
            {
                Bullet bullet = Instantiate(prefabBullet, tip.position, tip.rotation, bulletContent);
                bullet.Logic(bulletSpeed);
            } 
        }
        ;


    }

    private void PlayerMovement()
    {
        float pitch = -Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float yaw = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float roll = 0.0f;

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            roll = -rotationSpeed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.E))
        {
            roll = rotationSpeed * Time.deltaTime;
        }
        transform.Rotate(new Vector3(pitch, yaw, roll), Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            
            UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}