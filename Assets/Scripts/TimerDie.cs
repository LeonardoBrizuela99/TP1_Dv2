using UnityEngine;

public class TimerDie : MonoBehaviour
{
    [SerializeField] float lifeTime = 1.0f;

    private void Start()
    {
        Destroy(gameObject,lifeTime);
    }
}
